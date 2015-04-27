namespace PdfTemplateTool
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonRunTemplate = new System.Windows.Forms.Button();
            this.richTextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.instructrionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headlinerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.confnumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headlinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmationNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.axAcroPDFViewer = new AxAcroPDFLib.AxAcroPDF();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxPreText = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trackBarPdfZoom = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStripMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStripEditor.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFViewer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPdfZoom)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1320, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.newTemplateToolStripMenuItem,
            this.openTemplateToolStripMenuItem,
            this.saveTemplateAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openToolStripMenuItem.Text = "Open PDF...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // newTemplateToolStripMenuItem
            // 
            this.newTemplateToolStripMenuItem.Name = "newTemplateToolStripMenuItem";
            this.newTemplateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newTemplateToolStripMenuItem.Text = "New Template";
            this.newTemplateToolStripMenuItem.Click += new System.EventHandler(this.newTemplateToolStripMenuItem_Click);
            // 
            // openTemplateToolStripMenuItem
            // 
            this.openTemplateToolStripMenuItem.Name = "openTemplateToolStripMenuItem";
            this.openTemplateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openTemplateToolStripMenuItem.Text = "Open Template...";
            this.openTemplateToolStripMenuItem.Click += new System.EventHandler(this.openTemplateToolStripMenuItem_Click);
            // 
            // saveTemplateAsToolStripMenuItem
            // 
            this.saveTemplateAsToolStripMenuItem.Name = "saveTemplateAsToolStripMenuItem";
            this.saveTemplateAsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveTemplateAsToolStripMenuItem.Text = "Save Template...";
            this.saveTemplateAsToolStripMenuItem.Click += new System.EventHandler(this.saveTemplateAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonHelp);
            this.groupBox2.Controls.Add(this.buttonRunTemplate);
            this.groupBox2.Controls.Add(this.richTextBoxEditor);
            this.groupBox2.Location = new System.Drawing.Point(6, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 530);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp.Location = new System.Drawing.Point(7, 500);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonRunTemplate
            // 
            this.buttonRunTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunTemplate.Enabled = false;
            this.buttonRunTemplate.Location = new System.Drawing.Point(573, 500);
            this.buttonRunTemplate.Name = "buttonRunTemplate";
            this.buttonRunTemplate.Size = new System.Drawing.Size(75, 23);
            this.buttonRunTemplate.TabIndex = 1;
            this.buttonRunTemplate.Text = "Run Template";
            this.buttonRunTemplate.UseVisualStyleBackColor = true;
            this.buttonRunTemplate.Click += new System.EventHandler(this.buttonRunTemplate_Click);
            // 
            // richTextBoxEditor
            // 
            this.richTextBoxEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxEditor.ContextMenuStrip = this.contextMenuStripEditor;
            this.richTextBoxEditor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEditor.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxEditor.Name = "richTextBoxEditor";
            this.richTextBoxEditor.Size = new System.Drawing.Size(641, 474);
            this.richTextBoxEditor.TabIndex = 0;
            this.richTextBoxEditor.Text = "";
            this.richTextBoxEditor.WordWrap = false;
            this.richTextBoxEditor.TextChanged += new System.EventHandler(this.richTextBoxTemplate_TextChanged);
            // 
            // contextMenuStripEditor
            // 
            this.contextMenuStripEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructrionsToolStripMenuItem,
            this.keywordsToolStripMenuItem});
            this.contextMenuStripEditor.Name = "contextMenuStripEditor";
            this.contextMenuStripEditor.Size = new System.Drawing.Size(141, 48);
            // 
            // instructrionsToolStripMenuItem
            // 
            this.instructrionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathToolStripMenuItem,
            this.headlinerToolStripMenuItem1,
            this.venueToolStripMenuItem1,
            this.dateToolStripMenuItem1,
            this.timeToolStripMenuItem1,
            this.sectionToolStripMenuItem1,
            this.rowToolStripMenuItem1,
            this.seatToolStripMenuItem1,
            this.barcodeToolStripMenuItem1,
            this.confnumToolStripMenuItem});
            this.instructrionsToolStripMenuItem.Name = "instructrionsToolStripMenuItem";
            this.instructrionsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.instructrionsToolStripMenuItem.Text = "Instructrions";
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pathToolStripMenuItem.Tag = "path ";
            this.pathToolStripMenuItem.Text = "path";
            // 
            // headlinerToolStripMenuItem1
            // 
            this.headlinerToolStripMenuItem1.Name = "headlinerToolStripMenuItem1";
            this.headlinerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.headlinerToolStripMenuItem1.Tag = "headliner ";
            this.headlinerToolStripMenuItem1.Text = "headliner";
            // 
            // venueToolStripMenuItem1
            // 
            this.venueToolStripMenuItem1.Name = "venueToolStripMenuItem1";
            this.venueToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.venueToolStripMenuItem1.Tag = "venue ";
            this.venueToolStripMenuItem1.Text = "venue";
            // 
            // dateToolStripMenuItem1
            // 
            this.dateToolStripMenuItem1.Name = "dateToolStripMenuItem1";
            this.dateToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dateToolStripMenuItem1.Tag = "date ";
            this.dateToolStripMenuItem1.Text = "date";
            // 
            // timeToolStripMenuItem1
            // 
            this.timeToolStripMenuItem1.Name = "timeToolStripMenuItem1";
            this.timeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.timeToolStripMenuItem1.Tag = "time ";
            this.timeToolStripMenuItem1.Text = "time";
            // 
            // sectionToolStripMenuItem1
            // 
            this.sectionToolStripMenuItem1.Name = "sectionToolStripMenuItem1";
            this.sectionToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sectionToolStripMenuItem1.Tag = "section ";
            this.sectionToolStripMenuItem1.Text = "section";
            // 
            // rowToolStripMenuItem1
            // 
            this.rowToolStripMenuItem1.Name = "rowToolStripMenuItem1";
            this.rowToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rowToolStripMenuItem1.Tag = "row ";
            this.rowToolStripMenuItem1.Text = "row";
            // 
            // seatToolStripMenuItem1
            // 
            this.seatToolStripMenuItem1.Name = "seatToolStripMenuItem1";
            this.seatToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.seatToolStripMenuItem1.Tag = "seat ";
            this.seatToolStripMenuItem1.Text = "seat";
            // 
            // barcodeToolStripMenuItem1
            // 
            this.barcodeToolStripMenuItem1.Name = "barcodeToolStripMenuItem1";
            this.barcodeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.barcodeToolStripMenuItem1.Tag = "barcode ";
            this.barcodeToolStripMenuItem1.Text = "barcode";
            // 
            // confnumToolStripMenuItem
            // 
            this.confnumToolStripMenuItem.Name = "confnumToolStripMenuItem";
            this.confnumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.confnumToolStripMenuItem.Tag = "confnum ";
            this.confnumToolStripMenuItem.Text = "confnum";
            // 
            // keywordsToolStripMenuItem
            // 
            this.keywordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headlinerToolStripMenuItem,
            this.venueToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.sectionToolStripMenuItem,
            this.rowToolStripMenuItem,
            this.seatToolStripMenuItem,
            this.barcodeToolStripMenuItem,
            this.confirmationNumberToolStripMenuItem});
            this.keywordsToolStripMenuItem.Name = "keywordsToolStripMenuItem";
            this.keywordsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.keywordsToolStripMenuItem.Text = "Regex";
            // 
            // headlinerToolStripMenuItem
            // 
            this.headlinerToolStripMenuItem.Name = "headlinerToolStripMenuItem";
            this.headlinerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.headlinerToolStripMenuItem.Tag = "(?<headliner>)";
            this.headlinerToolStripMenuItem.Text = "Headliner";
            // 
            // venueToolStripMenuItem
            // 
            this.venueToolStripMenuItem.Name = "venueToolStripMenuItem";
            this.venueToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.venueToolStripMenuItem.Tag = "(?<venue>)";
            this.venueToolStripMenuItem.Text = "Venue";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.dateToolStripMenuItem.Tag = "(?<date>)";
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.timeToolStripMenuItem.Tag = "(?<time>)";
            this.timeToolStripMenuItem.Text = "Time";
            // 
            // sectionToolStripMenuItem
            // 
            this.sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            this.sectionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sectionToolStripMenuItem.Tag = "(?<section>)";
            this.sectionToolStripMenuItem.Text = "Section";
            // 
            // rowToolStripMenuItem
            // 
            this.rowToolStripMenuItem.Name = "rowToolStripMenuItem";
            this.rowToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rowToolStripMenuItem.Tag = "(?<row>)";
            this.rowToolStripMenuItem.Text = "Row";
            // 
            // seatToolStripMenuItem
            // 
            this.seatToolStripMenuItem.Name = "seatToolStripMenuItem";
            this.seatToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.seatToolStripMenuItem.Tag = "(?<seat>)";
            this.seatToolStripMenuItem.Text = "Seat";
            // 
            // barcodeToolStripMenuItem
            // 
            this.barcodeToolStripMenuItem.Name = "barcodeToolStripMenuItem";
            this.barcodeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.barcodeToolStripMenuItem.Tag = "(?<barcode>)";
            this.barcodeToolStripMenuItem.Text = "Barcode";
            // 
            // confirmationNumberToolStripMenuItem
            // 
            this.confirmationNumberToolStripMenuItem.Name = "confirmationNumberToolStripMenuItem";
            this.confirmationNumberToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.confirmationNumberToolStripMenuItem.Tag = "(?<confnum>)";
            this.confirmationNumberToolStripMenuItem.Text = "Confirmation Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.richTextBoxResults);
            this.groupBox3.Location = new System.Drawing.Point(6, 567);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 185);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxResults.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxResults.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.ReadOnly = true;
            this.richTextBoxResults.Size = new System.Drawing.Size(645, 159);
            this.richTextBoxResults.TabIndex = 0;
            this.richTextBoxResults.Text = "";
            this.richTextBoxResults.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PDF Path";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(62, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(602, 20);
            this.textBoxPath.TabIndex = 7;
            // 
            // axAcroPDFViewer
            // 
            this.axAcroPDFViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDFViewer.Enabled = true;
            this.axAcroPDFViewer.Location = new System.Drawing.Point(6, 6);
            this.axAcroPDFViewer.Name = "axAcroPDFViewer";
            this.axAcroPDFViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFViewer.OcxState")));
            this.axAcroPDFViewer.Size = new System.Drawing.Size(583, 663);
            this.axAcroPDFViewer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.richTextBoxPreText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(595, 726);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extracted Text";
            // 
            // richTextBoxPreText
            // 
            this.richTextBoxPreText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxPreText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPreText.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxPreText.Name = "richTextBoxPreText";
            this.richTextBoxPreText.ReadOnly = true;
            this.richTextBoxPreText.Size = new System.Drawing.Size(583, 714);
            this.richTextBoxPreText.TabIndex = 0;
            this.richTextBoxPreText.Text = "";
            this.richTextBoxPreText.WordWrap = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.trackBarPdfZoom);
            this.tabPage1.Controls.Add(this.axAcroPDFViewer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF";
            // 
            // trackBarPdfZoom
            // 
            this.trackBarPdfZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPdfZoom.Enabled = false;
            this.trackBarPdfZoom.Location = new System.Drawing.Point(6, 675);
            this.trackBarPdfZoom.Maximum = 100;
            this.trackBarPdfZoom.Minimum = 25;
            this.trackBarPdfZoom.Name = "trackBarPdfZoom";
            this.trackBarPdfZoom.Size = new System.Drawing.Size(583, 45);
            this.trackBarPdfZoom.TabIndex = 1;
            this.trackBarPdfZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPdfZoom.Value = 25;
            this.trackBarPdfZoom.ValueChanged += new System.EventHandler(this.trackBarPdfZoom_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 752);
            this.tabControl1.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPath);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1296, 755);
            this.splitContainer1.SplitterDistance = 609;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 798);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "PDF Template Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStripEditor.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFViewer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPdfZoom)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxEditor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ToolStripMenuItem openTemplateToolStripMenuItem;
        private System.Windows.Forms.Button buttonRunTemplate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ToolStripMenuItem newTemplateToolStripMenuItem;
        private AxAcroPDFLib.AxAcroPDF axAcroPDFViewer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxPreText;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar trackBarPdfZoom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEditor;
        private System.Windows.Forms.ToolStripMenuItem keywordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headlinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmationNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructrionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headlinerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem barcodeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem confnumToolStripMenuItem;
    }
}

