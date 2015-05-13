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
        Bitmap processorBitmap = null;
        int startX = 0;
        int startY = 0;
        int endX = 0;
        int endY = 0;
        int mouseClick = 0;

        public FormMain()
        {
            InitializeComponent();
            loadMacros();
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
            mouseClick = 0;
            richTextBoxResults.Text = "";           
            richTextBoxExtractedText.Text = "";
            pictureBoxBitmap.Image = null;

            using (Processor processor = new Processor())
            {
                Template template = new Template();
                template.SetText(richTextBoxEditor.Text);
                List<Result> results = processor.ProcessPDF(textBoxPath.Text, template);

                var json = JsonConvert.SerializeObject(results, Formatting.Indented, new JsonConverter[] { new StringEnumConverter() });
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
                    if (processorBitmap != null)
                    {
                        processorBitmap.Dispose();
                    }
                    processorBitmap = new Bitmap(processor.Bitmap);
                    pictureBoxBitmap.Image = processorBitmap;
                }

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

        private void loadMacros ()
        {
            string macroPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "macros");
            string[] files;
            try
            {
                files = Directory.GetFiles(macroPath);
            }
            catch (Exception)
            {
                return;
            }
            
            Array.Sort<string>(files);

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);
                if (extension == ".txt")
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    string filename = Path.GetFileName(file);
                    item.Text = filename.Substring(0, filename.Length - extension.Length);
                    item.Tag = file;
                    item.Click += macro_Click;
                    macrosToolStripMenuItem.DropDown.Items.Add(item);
                }
            }

            if (files.Length == 0)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Enabled = false;
                item.Text = "No macros";
                macrosToolStripMenuItem.DropDown.Items.Add(item);
            }
        }

        private void macro_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string text = System.IO.File.ReadAllText((string)item.Tag);
            richTextBoxEditor.AppendText(text + '\n');
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            
            if (fileDialog.ShowDialog(this) == DialogResult.OK)
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
                    if (MessageBox.Show(this, "Open template.txt from the same directory?", "Open Template", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

            if (fileDialog.ShowDialog(this) == DialogResult.OK)
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

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.SelectedText = "";
        }

        private void pictureBoxBitmap_MouseMove(object sender, MouseEventArgs e)
        {
            if (processorBitmap != null) 
            {
                float xPercent = e.X / (float)pictureBoxBitmap.Width;
                float yPercent = e.Y / (float)pictureBoxBitmap.Height;
                int currentX = Math.Min((int)(xPercent * processorBitmap.Width + 0.5f), processorBitmap.Width);
                int currentY = Math.Min((int)(yPercent * processorBitmap.Height + 0.5f), processorBitmap.Height);

                switch (mouseClick)
                {
                    case 0 :
                        labelBitmapPosition.Text = string.Format("{0}, {1} px", currentX, currentY);
                        break;

                    case 1 :
                        {
                            xPercent = startX / (float)pictureBoxBitmap.Width;
                            yPercent = startY / (float)pictureBoxBitmap.Height;
                            int anchorX = Math.Min((int)(xPercent * processorBitmap.Width + 0.5f), processorBitmap.Width);
                            int anchorY = Math.Min((int)(yPercent * processorBitmap.Height + 0.5f), processorBitmap.Height);

                            xPercent = e.X / (float)pictureBoxBitmap.Width;
                            yPercent = e.Y / (float)pictureBoxBitmap.Height;
                            int lastX = Math.Min((int)(xPercent * processorBitmap.Width + 0.5f), processorBitmap.Width);
                            int lastY = Math.Min((int)(yPercent * processorBitmap.Height + 0.5f), processorBitmap.Height);

                            labelBitmapPosition.Text = string.Format("{0}, {1} px ({2}, {3} px, {4}, {5})",
                                                                     currentX,
                                                                     currentY,
                                                                     anchorX,
                                                                     anchorY,
                                                                     Math.Abs(lastX - anchorX),
                                                                     Math.Abs(lastY - anchorY));
                        }
                        break;

                    case 2 :
                        {
                            xPercent = startX / (float)pictureBoxBitmap.Width;
                            yPercent = startY / (float)pictureBoxBitmap.Height;
                            int anchorX = Math.Min((int)(xPercent * processorBitmap.Width + 0.5f), processorBitmap.Width);
                            int anchorY = Math.Min((int)(yPercent * processorBitmap.Height + 0.5f), processorBitmap.Height);

                            xPercent = endX / (float)pictureBoxBitmap.Width;
                            yPercent = endY / (float)pictureBoxBitmap.Height;
                            int lastX = Math.Min((int)(xPercent * processorBitmap.Width + 0.5f), processorBitmap.Width);
                            int lastY = Math.Min((int)(yPercent * processorBitmap.Height + 0.5f), processorBitmap.Height);

                            labelBitmapPosition.Text = string.Format("{0}, {1} px ({2}, {3} px, {4}, {5})", 
                                                                     currentX,
                                                                     currentY, 
                                                                     anchorX, 
                                                                     anchorY, 
                                                                     Math.Abs(lastX - anchorX),
                                                                     Math.Abs(lastY - anchorY));
                        }
                        break;
                }
            }
        }
       

        private void pictureBoxBitmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (processorBitmap != null)
            {
                switch (mouseClick)
                {
                    case 0 :
                        startX = e.X;
                        startY = e.Y;
                        break;
                    case 1 :
                        endX = e.X;
                        endY = e.Y;
                        break;
                }

                mouseClick = (mouseClick + 1) % 3;
            }
        }
    }
}
