namespace Voice_Pad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Clear = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.wordWrapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.speedtrackBar = new System.Windows.Forms.TrackBar();
            this.volumetrackBar = new System.Windows.Forms.TrackBar();
            this.speedshow = new System.Windows.Forms.TextBox();
            this.Volshow = new System.Windows.Forms.TextBox();
            this.rateup = new System.Windows.Forms.Button();
            this.ratedown = new System.Windows.Forms.Button();
            this.Speedlabel = new System.Windows.Forms.Label();
            this.volumelabel = new System.Windows.Forms.Label();
            this.volup = new System.Windows.Forms.Button();
            this.voldown = new System.Windows.Forms.Button();
            this.selectvoicelabel = new System.Windows.Forms.Label();
            this.FemaleVoiceradioButton = new System.Windows.Forms.RadioButton();
            this.MaleVoiceradioButton = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumetrackBar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.Clear);
            this.tabPage1.Controls.Add(this.Paste);
            this.tabPage1.Controls.Add(this.Stop);
            this.tabPage1.Controls.Add(this.Pause);
            this.tabPage1.Controls.Add(this.Read);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Tomato;
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Location = new System.Drawing.Point(843, 353);
            this.Clear.Name = "Clear";
            this.Clear.Padding = new System.Windows.Forms.Padding(2);
            this.Clear.Size = new System.Drawing.Size(75, 33);
            this.Clear.TabIndex = 37;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Button_click);
            // 
            // Paste
            // 
            this.Paste.BackColor = System.Drawing.Color.GreenYellow;
            this.Paste.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paste.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paste.Location = new System.Drawing.Point(843, 29);
            this.Paste.Name = "Paste";
            this.Paste.Padding = new System.Windows.Forms.Padding(2);
            this.Paste.Size = new System.Drawing.Size(75, 33);
            this.Paste.TabIndex = 36;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = false;
            this.Paste.Click += new System.EventHandler(this.Paste_Button_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Silver;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stop.Location = new System.Drawing.Point(760, 399);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 29);
            this.Stop.TabIndex = 35;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Silver;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pause.Location = new System.Drawing.Point(12, 399);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 29);
            this.Pause.TabIndex = 34;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Read.FlatAppearance.BorderSize = 3;
            this.Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Read.Location = new System.Drawing.Point(387, 394);
            this.Read.Name = "Read";
            this.Read.Padding = new System.Windows.Forms.Padding(3);
            this.Read.Size = new System.Drawing.Size(75, 30);
            this.Read.TabIndex = 32;
            this.Read.Text = "Read ";
            this.Read.UseVisualStyleBackColor = false;
            this.Read.Click += new System.EventHandler(this.speech);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 29);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(823, 357);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            this.richTextBox1.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(193, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.s1ToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.s2ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem2_Click);
            // 
            // s1ToolStripMenuItem
            // 
            this.s1ToolStripMenuItem.Name = "s1ToolStripMenuItem";
            this.s1ToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as ..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // s2ToolStripMenuItem
            // 
            this.s2ToolStripMenuItem.Name = "s2ToolStripMenuItem";
            this.s2ToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.nToolStripMenuItem2,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = " Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutAction);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyAction);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteAction);
            // 
            // nToolStripMenuItem2
            // 
            this.nToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nToolStripMenuItem2.Name = "nToolStripMenuItem2";
            this.nToolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllAction);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearAction);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllAction);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoAction);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoAction);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.toolStripSeparator3,
            this.colorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.wordWrapToolStripMenuItem,
            this.wordWrapToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem2.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(167, 6);
            // 
            // wordWrapToolStripMenuItem1
            // 
            this.wordWrapToolStripMenuItem1.Checked = true;
            this.wordWrapToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapToolStripMenuItem1.Name = "wordWrapToolStripMenuItem1";
            this.wordWrapToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.wordWrapToolStripMenuItem1.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem1.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.speedtrackBar);
            this.tabPage2.Controls.Add(this.volumetrackBar);
            this.tabPage2.Controls.Add(this.speedshow);
            this.tabPage2.Controls.Add(this.Volshow);
            this.tabPage2.Controls.Add(this.rateup);
            this.tabPage2.Controls.Add(this.ratedown);
            this.tabPage2.Controls.Add(this.Speedlabel);
            this.tabPage2.Controls.Add(this.volumelabel);
            this.tabPage2.Controls.Add(this.volup);
            this.tabPage2.Controls.Add(this.voldown);
            this.tabPage2.Controls.Add(this.selectvoicelabel);
            this.tabPage2.Controls.Add(this.FemaleVoiceradioButton);
            this.tabPage2.Controls.Add(this.MaleVoiceradioButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // speedtrackBar
            // 
            this.speedtrackBar.LargeChange = 1;
            this.speedtrackBar.Location = new System.Drawing.Point(77, 374);
            this.speedtrackBar.Minimum = -10;
            this.speedtrackBar.Name = "speedtrackBar";
            this.speedtrackBar.Size = new System.Drawing.Size(781, 45);
            this.speedtrackBar.TabIndex = 54;
            this.speedtrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // volumetrackBar
            // 
            this.volumetrackBar.Location = new System.Drawing.Point(77, 224);
            this.volumetrackBar.Maximum = 100;
            this.volumetrackBar.Name = "volumetrackBar";
            this.volumetrackBar.Size = new System.Drawing.Size(781, 45);
            this.volumetrackBar.TabIndex = 53;
            this.volumetrackBar.Value = 100;
            this.volumetrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // speedshow
            // 
            this.speedshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.speedshow.Location = new System.Drawing.Point(375, 330);
            this.speedshow.Name = "speedshow";
            this.speedshow.ReadOnly = true;
            this.speedshow.Size = new System.Drawing.Size(175, 38);
            this.speedshow.TabIndex = 52;
            this.speedshow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedshow.TextChanged += new System.EventHandler(this.speedshow_TextChanged);
            // 
            // Volshow
            // 
            this.Volshow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Volshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volshow.Location = new System.Drawing.Point(375, 168);
            this.Volshow.Name = "Volshow";
            this.Volshow.ReadOnly = true;
            this.Volshow.Size = new System.Drawing.Size(175, 38);
            this.Volshow.TabIndex = 51;
            this.Volshow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Volshow.TextChanged += new System.EventHandler(this.Volshow_TextChanged);
            // 
            // rateup
            // 
            this.rateup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rateup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rateup.Location = new System.Drawing.Point(862, 374);
            this.rateup.Name = "rateup";
            this.rateup.Padding = new System.Windows.Forms.Padding(2);
            this.rateup.Size = new System.Drawing.Size(47, 45);
            this.rateup.TabIndex = 50;
            this.rateup.Text = "+";
            this.rateup.UseVisualStyleBackColor = false;
            this.rateup.Click += new System.EventHandler(this.rateup_Click);
            // 
            // ratedown
            // 
            this.ratedown.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ratedown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratedown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ratedown.Location = new System.Drawing.Point(24, 374);
            this.ratedown.Name = "ratedown";
            this.ratedown.Padding = new System.Windows.Forms.Padding(2);
            this.ratedown.Size = new System.Drawing.Size(47, 45);
            this.ratedown.TabIndex = 49;
            this.ratedown.Text = "-";
            this.ratedown.UseVisualStyleBackColor = false;
            this.ratedown.Click += new System.EventHandler(this.ratedown_Click);
            // 
            // Speedlabel
            // 
            this.Speedlabel.AutoSize = true;
            this.Speedlabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Speedlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Speedlabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.Speedlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Speedlabel.Location = new System.Drawing.Point(428, 282);
            this.Speedlabel.Name = "Speedlabel";
            this.Speedlabel.Padding = new System.Windows.Forms.Padding(3);
            this.Speedlabel.Size = new System.Drawing.Size(81, 34);
            this.Speedlabel.TabIndex = 48;
            this.Speedlabel.Text = "Speed";
            this.Speedlabel.MouseHover += new System.EventHandler(this.Speedlabel_MouseHover);
            // 
            // volumelabel
            // 
            this.volumelabel.AutoSize = true;
            this.volumelabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.volumelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.volumelabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.volumelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volumelabel.Location = new System.Drawing.Point(412, 109);
            this.volumelabel.Name = "volumelabel";
            this.volumelabel.Padding = new System.Windows.Forms.Padding(3);
            this.volumelabel.Size = new System.Drawing.Size(97, 34);
            this.volumelabel.TabIndex = 47;
            this.volumelabel.Text = "Volume";
            this.volumelabel.MouseHover += new System.EventHandler(this.Volumelabel_MouseHover);
            // 
            // volup
            // 
            this.volup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.volup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volup.Location = new System.Drawing.Point(862, 224);
            this.volup.Name = "volup";
            this.volup.Padding = new System.Windows.Forms.Padding(2);
            this.volup.Size = new System.Drawing.Size(47, 45);
            this.volup.TabIndex = 46;
            this.volup.Text = "+";
            this.volup.UseVisualStyleBackColor = false;
            this.volup.Click += new System.EventHandler(this.volup_Click);
            // 
            // voldown
            // 
            this.voldown.BackColor = System.Drawing.Color.LightSteelBlue;
            this.voldown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voldown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.voldown.Location = new System.Drawing.Point(24, 224);
            this.voldown.Name = "voldown";
            this.voldown.Padding = new System.Windows.Forms.Padding(2);
            this.voldown.Size = new System.Drawing.Size(47, 45);
            this.voldown.TabIndex = 45;
            this.voldown.Text = "-";
            this.voldown.UseVisualStyleBackColor = false;
            this.voldown.Click += new System.EventHandler(this.voldown_Click);
            // 
            // selectvoicelabel
            // 
            this.selectvoicelabel.AutoSize = true;
            this.selectvoicelabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.selectvoicelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectvoicelabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectvoicelabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectvoicelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectvoicelabel.Location = new System.Drawing.Point(390, 3);
            this.selectvoicelabel.Name = "selectvoicelabel";
            this.selectvoicelabel.Padding = new System.Windows.Forms.Padding(3);
            this.selectvoicelabel.Size = new System.Drawing.Size(149, 34);
            this.selectvoicelabel.TabIndex = 44;
            this.selectvoicelabel.Text = "Select Voice ";
            this.selectvoicelabel.MouseHover += new System.EventHandler(this.Voicecgenderlabel_MouseHover);
            // 
            // FemaleVoiceradioButton
            // 
            this.FemaleVoiceradioButton.AutoSize = true;
            this.FemaleVoiceradioButton.Checked = true;
            this.FemaleVoiceradioButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.FemaleVoiceradioButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FemaleVoiceradioButton.Location = new System.Drawing.Point(681, 70);
            this.FemaleVoiceradioButton.Name = "FemaleVoiceradioButton";
            this.FemaleVoiceradioButton.Padding = new System.Windows.Forms.Padding(2);
            this.FemaleVoiceradioButton.Size = new System.Drawing.Size(109, 34);
            this.FemaleVoiceradioButton.TabIndex = 43;
            this.FemaleVoiceradioButton.TabStop = true;
            this.FemaleVoiceradioButton.Text = "Female";
            this.FemaleVoiceradioButton.UseVisualStyleBackColor = true;
            this.FemaleVoiceradioButton.Click += new System.EventHandler(this.voicefemale);
            // 
            // MaleVoiceradioButton
            // 
            this.MaleVoiceradioButton.AutoSize = true;
            this.MaleVoiceradioButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.MaleVoiceradioButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaleVoiceradioButton.Location = new System.Drawing.Point(131, 70);
            this.MaleVoiceradioButton.Name = "MaleVoiceradioButton";
            this.MaleVoiceradioButton.Padding = new System.Windows.Forms.Padding(2);
            this.MaleVoiceradioButton.Size = new System.Drawing.Size(87, 34);
            this.MaleVoiceradioButton.TabIndex = 42;
            this.MaleVoiceradioButton.Text = "Male";
            this.MaleVoiceradioButton.UseVisualStyleBackColor = true;
            this.MaleVoiceradioButton.Click += new System.EventHandler(this.voicemale);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Settings";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoicePad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumetrackBar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator s1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator s2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator nToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox speedshow;
        private System.Windows.Forms.Button rateup;
        private System.Windows.Forms.Button ratedown;
        private System.Windows.Forms.Label Speedlabel;
        private System.Windows.Forms.Label volumelabel;
        private System.Windows.Forms.Button volup;
        private System.Windows.Forms.Button voldown;
        private System.Windows.Forms.Label selectvoicelabel;
        private System.Windows.Forms.RadioButton FemaleVoiceradioButton;
        private System.Windows.Forms.RadioButton MaleVoiceradioButton;
        private System.Windows.Forms.TrackBar volumetrackBar;
        private System.Windows.Forms.TrackBar speedtrackBar;
        private System.Windows.Forms.TextBox Volshow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

