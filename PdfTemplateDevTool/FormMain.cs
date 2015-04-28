using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PdfTemplateLib;

namespace PdfTemplateTool
{
    public partial class FormMain : Form
    {
        string templatePath = null;
        bool templateDirty = false;

        public FormMain()
        {
            InitializeComponent();

            editor_context_menu((ToolStripMenuItem)contextMenuStripEditor.Items[0]);
            editor_context_menu((ToolStripMenuItem)contextMenuStripEditor.Items[1]);
        }
        
        private void getPreText(string pdfPath)
        {
            richTextBoxPreText.Text = "";

            PdfReader reader = new PdfReader(pdfPath);

            for (int i = 1; i <= reader.NumberOfPages; ++i)
            {
                string pdfText = PdfTextExtractor.GetTextFromPage(reader, i);

                if (i > 1)
                {
                    break;  // Just stop after the first page.
                    richTextBoxPreText.AppendText("------------------------------------------------------------------\r\n");
                    richTextBoxPreText.AppendText(string.Format("Page {0}\r\n\r\n", i));
                }

                string[] pdfLines = pdfText.Split('\n');
                int k = 0;
                foreach (string line in pdfLines)
                {
                    richTextBoxPreText.AppendText(string.Format("{0,4:G}\t{1}\r\n", k, line));
                    ++k;
                }
            }

            reader.Close();
        }

        private void loadTemplate(string path, MessageBoxButtons buttons)
        {
            if (!checkTemplate(buttons))
            {
                return;
            }

            richTextBoxEditor.Text = "";
            templateDirty = false;

            try
            {
                string text = File.ReadAllText(path);
                richTextBoxEditor.Text = text;
                templateDirty = false;
                templatePath = path;
                setTitle();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed reading template.", "Error");
            }
        }

        private void processTemplate()
        {
            richTextBoxExtractedText.Text = "";
            pictureBoxBitmap.Image = null;

            Template template = new Template();
            template.SetText(richTextBoxEditor.Text);

            Processor processor = new Processor();
            Result result = processor.ProcessPDF(textBoxPath.Text, template);
            
            var json = JsonConvert.SerializeObject(result, Formatting.Indented, new JsonConverter[] { new StringEnumConverter() });
            richTextBoxResults.Text = json;

            if (processor.Text != null)
            {
                int k = 0;
                foreach (string line in processor.Text)
                {
                    richTextBoxExtractedText.AppendText(string.Format("{0,4:G}\t{1}\r\n", k, line));
                    ++k;
                }
            }

            if (processor.Bitmap != null)
            {
                pictureBoxBitmap.Image = processor.Bitmap;
            }
        }

        private bool checkTemplate(MessageBoxButtons buttons)
        {
            if (templateDirty)
            {
                DialogResult result = MessageBox.Show("The current template changed. Save changes?", "Save Template", buttons);
                if (result == DialogResult.Cancel)
                {
                    return false;
                }
                else if (result == DialogResult.Yes)
                {
                    saveTemplate();
                }
            }

            return true;
        }

        private void saveTemplate ()
        {
            string pdfPath = textBoxPath.Text;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Template files (*.txt)|*.txt|All files (*.*)|*.*";

            if (pdfPath.Length > 0)
            {
                string path = Path.GetDirectoryName(pdfPath) + "\\template.txt";
                dialog.FileName = path;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName))
                {
                    sw.Write(richTextBoxEditor.Text);
                }
                templateDirty = false;
            }
        }

        private void setTitle ()
        {
            string text = templatePath;
            if (text == null)
            {
                text = "[unsaved template]";
            }
            else if (templateDirty)
            {
                text += " [modified]";
            }
            this.Text = string.Format("{0} - PDF Template Tool", text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                axAcroPDFViewer.LoadFile(fileDialog.FileName);

                buttonRunTemplate.Enabled = true;
                trackBarPdfZoom.Enabled = true;
                trackBarPdfZoom.Value = 50;
                textBoxPath.Text = fileDialog.FileName;
                getPreText(fileDialog.FileName);

                string path = Path.GetDirectoryName(fileDialog.FileName) + "\\template.txt";
                if (File.Exists(path))
                {
                    if (MessageBox.Show("Open template.txt from the same directory?", "Open Template", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        loadTemplate(path, MessageBoxButtons.YesNo);
                        return;
                    }
                }

                checkTemplate(MessageBoxButtons.YesNo);
                this.Text = "PDF Template Tool";
                richTextBoxEditor.Text = "";
                templateDirty = false;
            }
        }

        private void openTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Template files (*.txt)|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                loadTemplate(fileDialog.FileName, MessageBoxButtons.YesNoCancel);
            }
        }
        
        private void buttonRunTemplate_Click(object sender, EventArgs e)
        {
            processTemplate();
        }             

        private void richTextBoxTemplate_TextChanged(object sender, EventArgs e)
        {
            bool dirty = templateDirty;
            templateDirty = true;

            if (dirty == false)
            {
                setTitle();
            }
        }

        private void saveTemplateAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTemplate();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormSyntaxHelp dialog = new FormSyntaxHelp();

            buttonHelp.Enabled = false;
            dialog.FormClosed += helpDialog_Closed;
            dialog.Show(this);
        }

        private void helpDialog_Closed(object sender, EventArgs e)
        {
            buttonHelp.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkTemplate(MessageBoxButtons.YesNoCancel) == false)
            {
                return;
            }

            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkTemplate(MessageBoxButtons.YesNoCancel) == false)
            {
                e.Cancel = true;
            }
        }

        private void newTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkTemplate(MessageBoxButtons.YesNoCancel) == false)
            {
                return;
            }

            richTextBoxResults.Text = "";
            richTextBoxEditor.Text = "";
            templateDirty = false;
            setTitle();
        }

        private void trackBarPdfZoom_ValueChanged(object sender, EventArgs e)
        {
            axAcroPDFViewer.setZoom(trackBarPdfZoom.Value);
        }

        private void editor_context_menu(ToolStripMenuItem menu)
        {
            foreach (ToolStripItem item in menu.DropDown.Items)
            {
                item.Click += editorContextItem_Click;
            }
        }

        void editorContextItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            richTextBoxEditor.AppendText((string)item.Tag);
        }
    }
}
