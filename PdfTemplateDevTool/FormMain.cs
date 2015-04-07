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

namespace PdfTemplateDevTool
{
    public partial class FormMain : Form
    {
        string[] pdfLines;

        public FormMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                axAcroPDFViewer.LoadFile(fileDialog.FileName);

                extractText(fileDialog.FileName);
                richTextBoxTemplate.Text = "";
                richTextBoxResults.Text = "";

                textBoxPath.Text = fileDialog.FileName;

                string templatePath = Path.GetDirectoryName(fileDialog.FileName) + "\\template.txt";
                if (File.Exists(templatePath))
                {
                    if (MessageBox.Show("Open template.txt from the same directory?", "Open Template", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        loadTemplate (templatePath);
                    }
                }                
            }
        }

        private void extractText (string pdfPath)
        {
            richTextBoxExtractedText.Text = "";

            using (PdfReader reader = new PdfReader(pdfPath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    if (i > 1)
                    {
                        break;  // Just stop after the first page.
                        richTextBoxExtractedText.AppendText("------------------------------------------------------------------\r\n");
                        richTextBoxExtractedText.AppendText(string.Format("Page {0}\r\n\r\n", i));
                    }

                    string text = PdfTextExtractor.GetTextFromPage(reader, i);
                    pdfLines = text.Split('\n');

                    int k = 0;
                    foreach (string line in pdfLines)
                    {
                        richTextBoxExtractedText.AppendText(string.Format("{0,4:G}\t{1}\r\n", k, line));
                        ++k;
                    }
                }
            }
        }

        private void loadTemplate(string templatePath)
        {
            richTextBoxTemplate.Text = "";

            try
            {
                string text = File.ReadAllText(templatePath);
                richTextBoxTemplate.AppendText(text);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed reading template.", "Error");
            }
        }

        private void processTemplate()
        {
            Template template = new Template();
            template.SetText(richTextBoxTemplate.Text);
            Result result = template.Run(textBoxPath.Text, pdfLines);
            var json = JsonConvert.SerializeObject(result, Formatting.Indented, new JsonConverter[] { new StringEnumConverter() });

            richTextBoxResults.Text = json;
        }

        private void buttonRunTemplate_Click(object sender, EventArgs e)
        {
            processTemplate();
        }       
    }
}
