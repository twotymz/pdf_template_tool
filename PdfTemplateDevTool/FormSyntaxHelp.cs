using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfTemplateTool
{
    public partial class FormSyntaxHelp : Form
    {
        public FormSyntaxHelp()
        {
            InitializeComponent();
        }

        private void FormSyntaxHelp_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = PdfTemplateTool.Properties.Resources.SyntaxHelp;
        }
    }
}
