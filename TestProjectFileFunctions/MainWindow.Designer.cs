namespace JFK_VarTab
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
            this.lblProjectInfo = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.treeStep7Project = new System.Windows.Forms.TreeView();
            this.imglstIconsForTreeview = new System.Windows.Forms.ImageList(this.components);
            this.dtaSymbolTable = new System.Windows.Forms.DataGridView();
            this.symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datatype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operandiec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tia_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListBox = new System.Windows.Forms.ListBox();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.chkShowDeleted = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSetKnowHow = new System.Windows.Forms.Button();
            this.cmdRemoveKnowHow = new System.Windows.Forms.Button();
            this.cmdUndeleteBlock = new System.Windows.Forms.Button();
            this.txtUndeleteName = new System.Windows.Forms.TextBox();
            this.grpVisu = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenTxt = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxMPI = new System.Windows.Forms.TextBox();
            this.textBoxSlot = new System.Windows.Forms.TextBox();
            this.textBoxRack = new System.Windows.Forms.TextBox();
            this.buttonCreateLogFile = new System.Windows.Forms.Button();
            this.buttonFastLogAWL = new System.Windows.Forms.Button();
            this.checkBoxUseDB_Name = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogfileName = new System.Windows.Forms.TextBox();
            this.txtTagsPrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fetchPLCData = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblToolStripFileSystemFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.cmdProjectsBrowser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attach14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attach15_1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertCallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExpandDatablockArrays = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parseAllBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAWLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.viewBlockList = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelVisu = new System.Windows.Forms.TableLayoutPanel();
            this.datablockView = new System.Windows.Forms.Integration.ElementHost();
            this.dtaPnPbList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.export = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hexBox = new Be.Windows.Forms.HexBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaSymbolTable)).BeginInit();
            this.grpVisu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.viewBlockList.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelVisu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaPnPbList)).BeginInit();
            this.exportMenu.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectInfo
            // 
            this.lblProjectInfo.Location = new System.Drawing.Point(95, 41);
            this.lblProjectInfo.Name = "lblProjectInfo";
            this.lblProjectInfo.Size = new System.Drawing.Size(690, 13);
            this.lblProjectInfo.TabIndex = 3;
            this.lblProjectInfo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.Location = new System.Drawing.Point(100, 26);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(643, 13);
            this.lblProjectName.TabIndex = 3;
            // 
            // treeStep7Project
            // 
            this.treeStep7Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeStep7Project.ImageIndex = 0;
            this.treeStep7Project.ImageList = this.imglstIconsForTreeview;
            this.treeStep7Project.Location = new System.Drawing.Point(3, 3);
            this.treeStep7Project.Name = "treeStep7Project";
            this.treeStep7Project.SelectedImageIndex = 0;
            this.treeStep7Project.Size = new System.Drawing.Size(367, 406);
            this.treeStep7Project.TabIndex = 4;
            this.treeStep7Project.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeStep7Project_BeforeCollapse);
            this.treeStep7Project.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeStep7Project_BeforeExpand);
            this.treeStep7Project.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeStep7Project.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeStep7Project_NodeMouseClick);
            this.treeStep7Project.Click += new System.EventHandler(this.treeView1_Click);
            this.treeStep7Project.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeStep7Project_MouseClick);
            // 
            // imglstIconsForTreeview
            // 
            this.imglstIconsForTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstIconsForTreeview.ImageStream")));
            this.imglstIconsForTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstIconsForTreeview.Images.SetKeyName(0, "Generic Folder   Closed.ico");
            this.imglstIconsForTreeview.Images.SetKeyName(1, "Generic Folder   Open.ico");
            this.imglstIconsForTreeview.Images.SetKeyName(2, "300er.png");
            this.imglstIconsForTreeview.Images.SetKeyName(3, "400er.png");
            this.imglstIconsForTreeview.Images.SetKeyName(4, "Rack300.png");
            this.imglstIconsForTreeview.Images.SetKeyName(5, "rack400.png");
            this.imglstIconsForTreeview.Images.SetKeyName(6, "Folder.png");
            this.imglstIconsForTreeview.Images.SetKeyName(7, "im151.png");
            this.imglstIconsForTreeview.Images.SetKeyName(8, "im151cpu.png");
            this.imglstIconsForTreeview.Images.SetKeyName(9, "cp.png");
            this.imglstIconsForTreeview.Images.SetKeyName(10, "s5.png");
            // 
            // dtaSymbolTable
            // 
            this.dtaSymbolTable.AllowUserToAddRows = false;
            this.dtaSymbolTable.AllowUserToDeleteRows = false;
            this.dtaSymbolTable.AllowUserToResizeRows = false;
            this.dtaSymbolTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaSymbolTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbol,
            this.datatype,
            this.operand,
            this.operandiec,
            this.comment,
            this.tia_key});
            this.dtaSymbolTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtaSymbolTable.Location = new System.Drawing.Point(0, 0);
            this.dtaSymbolTable.Name = "dtaSymbolTable";
            this.dtaSymbolTable.RowHeadersWidth = 82;
            this.dtaSymbolTable.Size = new System.Drawing.Size(730, 543);
            this.dtaSymbolTable.TabIndex = 5;
            this.dtaSymbolTable.Visible = false;
            // 
            // symbol
            // 
            this.symbol.HeaderText = "symbol";
            this.symbol.MinimumWidth = 10;
            this.symbol.Name = "symbol";
            this.symbol.Width = 200;
            // 
            // datatype
            // 
            this.datatype.HeaderText = "datatype";
            this.datatype.MinimumWidth = 10;
            this.datatype.Name = "datatype";
            this.datatype.Width = 200;
            // 
            // operand
            // 
            this.operand.HeaderText = "operand";
            this.operand.MinimumWidth = 10;
            this.operand.Name = "operand";
            this.operand.Width = 200;
            // 
            // operandiec
            // 
            this.operandiec.HeaderText = "operandiec";
            this.operandiec.MinimumWidth = 10;
            this.operandiec.Name = "operandiec";
            this.operandiec.Width = 200;
            // 
            // comment
            // 
            this.comment.HeaderText = "comment";
            this.comment.MinimumWidth = 10;
            this.comment.Name = "comment";
            this.comment.Width = 200;
            // 
            // tia_key
            // 
            this.tia_key.HeaderText = "tia_key";
            this.tia_key.MinimumWidth = 10;
            this.tia_key.Name = "tia_key";
            this.tia_key.Width = 200;
            // 
            // lstListBox
            // 
            this.lstListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListBox.FormattingEnabled = true;
            this.lstListBox.ItemHeight = 16;
            this.lstListBox.Location = new System.Drawing.Point(3, 3);
            this.lstListBox.Name = "lstListBox";
            this.lstListBox.Size = new System.Drawing.Size(474, 476);
            this.lstListBox.TabIndex = 6;
            this.lstListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lstListBox.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.lstListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstListBox_KeyPress);
            // 
            // txtTextBox
            // 
            this.txtTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextBox.Location = new System.Drawing.Point(0, 0);
            this.txtTextBox.Multiline = true;
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextBox.Size = new System.Drawing.Size(730, 543);
            this.txtTextBox.TabIndex = 7;
            this.txtTextBox.Visible = false;
            this.txtTextBox.WordWrap = false;
            // 
            // chkShowDeleted
            // 
            this.chkShowDeleted.AutoSize = true;
            this.chkShowDeleted.Location = new System.Drawing.Point(3, 522);
            this.chkShowDeleted.Name = "chkShowDeleted";
            this.chkShowDeleted.Size = new System.Drawing.Size(105, 18);
            this.chkShowDeleted.TabIndex = 8;
            this.chkShowDeleted.Text = "Show deleted";
            this.chkShowDeleted.UseVisualStyleBackColor = true;
            this.chkShowDeleted.Visible = false;
            this.chkShowDeleted.CheckedChanged += new System.EventHandler(this.chkShowDeleted_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Project Info:";
            // 
            // cmdSetKnowHow
            // 
            this.cmdSetKnowHow.Location = new System.Drawing.Point(3, 3);
            this.cmdSetKnowHow.Name = "cmdSetKnowHow";
            this.cmdSetKnowHow.Size = new System.Drawing.Size(166, 24);
            this.cmdSetKnowHow.TabIndex = 10;
            this.cmdSetKnowHow.Text = "Set Know How Protection";
            this.cmdSetKnowHow.UseVisualStyleBackColor = true;
            this.cmdSetKnowHow.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdRemoveKnowHow
            // 
            this.cmdRemoveKnowHow.Location = new System.Drawing.Point(175, 3);
            this.cmdRemoveKnowHow.Name = "cmdRemoveKnowHow";
            this.cmdRemoveKnowHow.Size = new System.Drawing.Size(184, 24);
            this.cmdRemoveKnowHow.TabIndex = 11;
            this.cmdRemoveKnowHow.Text = "Remove Know How Protection";
            this.cmdRemoveKnowHow.UseVisualStyleBackColor = true;
            this.cmdRemoveKnowHow.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdUndeleteBlock
            // 
            this.cmdUndeleteBlock.Location = new System.Drawing.Point(365, 3);
            this.cmdUndeleteBlock.Name = "cmdUndeleteBlock";
            this.cmdUndeleteBlock.Size = new System.Drawing.Size(164, 24);
            this.cmdUndeleteBlock.TabIndex = 12;
            this.cmdUndeleteBlock.Text = "Undelete Block";
            this.cmdUndeleteBlock.UseVisualStyleBackColor = true;
            this.cmdUndeleteBlock.Visible = false;
            this.cmdUndeleteBlock.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtUndeleteName
            // 
            this.txtUndeleteName.Location = new System.Drawing.Point(535, 3);
            this.txtUndeleteName.Name = "txtUndeleteName";
            this.txtUndeleteName.Size = new System.Drawing.Size(68, 22);
            this.txtUndeleteName.TabIndex = 13;
            this.txtUndeleteName.Text = "9999";
            this.txtUndeleteName.Visible = false;
            // 
            // grpVisu
            // 
            this.grpVisu.Controls.Add(this.checkBox1);
            this.grpVisu.Controls.Add(this.checkBoxOpenTxt);
            this.grpVisu.Controls.Add(this.label12);
            this.grpVisu.Controls.Add(this.label11);
            this.grpVisu.Controls.Add(this.label10);
            this.grpVisu.Controls.Add(this.label8);
            this.grpVisu.Controls.Add(this.textBoxIP);
            this.grpVisu.Controls.Add(this.textBoxMPI);
            this.grpVisu.Controls.Add(this.textBoxSlot);
            this.grpVisu.Controls.Add(this.textBoxRack);
            this.grpVisu.Controls.Add(this.buttonCreateLogFile);
            this.grpVisu.Controls.Add(this.buttonFastLogAWL);
            this.grpVisu.Controls.Add(this.checkBoxUseDB_Name);
            this.grpVisu.Controls.Add(this.label9);
            this.grpVisu.Controls.Add(this.txtLogfileName);
            this.grpVisu.Controls.Add(this.txtTagsPrefix);
            this.grpVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVisu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.grpVisu.Location = new System.Drawing.Point(483, 3);
            this.grpVisu.Name = "grpVisu";
            this.grpVisu.Size = new System.Drawing.Size(232, 476);
            this.grpVisu.TabIndex = 16;
            this.grpVisu.TabStop = false;
            this.grpVisu.Text = "Logfile Toolbox";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 19);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBoxExpandArray";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpenTxt
            // 
            this.checkBoxOpenTxt.AutoSize = true;
            this.checkBoxOpenTxt.Location = new System.Drawing.Point(10, 95);
            this.checkBoxOpenTxt.Name = "checkBoxOpenTxt";
            this.checkBoxOpenTxt.Size = new System.Drawing.Size(218, 19);
            this.checkBoxOpenTxt.TabIndex = 19;
            this.checkBoxOpenTxt.Text = "Open Logfile upon completion";
            this.checkBoxOpenTxt.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "DP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Slot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rack";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(10, 248);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(133, 23);
            this.textBoxIP.TabIndex = 14;
            // 
            // textBoxMPI
            // 
            this.textBoxMPI.Location = new System.Drawing.Point(106, 292);
            this.textBoxMPI.Name = "textBoxMPI";
            this.textBoxMPI.Size = new System.Drawing.Size(37, 23);
            this.textBoxMPI.TabIndex = 13;
            // 
            // textBoxSlot
            // 
            this.textBoxSlot.Location = new System.Drawing.Point(59, 292);
            this.textBoxSlot.Name = "textBoxSlot";
            this.textBoxSlot.Size = new System.Drawing.Size(37, 23);
            this.textBoxSlot.TabIndex = 12;
            // 
            // textBoxRack
            // 
            this.textBoxRack.Location = new System.Drawing.Point(9, 292);
            this.textBoxRack.Name = "textBoxRack";
            this.textBoxRack.Size = new System.Drawing.Size(37, 23);
            this.textBoxRack.TabIndex = 11;
            // 
            // buttonCreateLogFile
            // 
            this.buttonCreateLogFile.Location = new System.Drawing.Point(9, 322);
            this.buttonCreateLogFile.Name = "buttonCreateLogFile";
            this.buttonCreateLogFile.Size = new System.Drawing.Size(207, 71);
            this.buttonCreateLogFile.TabIndex = 10;
            this.buttonCreateLogFile.Text = "Create PLC Log Setup File";
            this.buttonCreateLogFile.UseVisualStyleBackColor = true;
            this.buttonCreateLogFile.Click += new System.EventHandler(this.buttonCreateLogFile_Click);
            // 
            // buttonFastLogAWL
            // 
            this.buttonFastLogAWL.Enabled = false;
            this.buttonFastLogAWL.Location = new System.Drawing.Point(9, 399);
            this.buttonFastLogAWL.Name = "buttonFastLogAWL";
            this.buttonFastLogAWL.Size = new System.Drawing.Size(207, 71);
            this.buttonFastLogAWL.TabIndex = 9;
            this.buttonFastLogAWL.Text = "Create FastLog FB Incl INT";
            this.buttonFastLogAWL.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseDB_Name
            // 
            this.checkBoxUseDB_Name.AutoSize = true;
            this.checkBoxUseDB_Name.Location = new System.Drawing.Point(9, 70);
            this.checkBoxUseDB_Name.Name = "checkBoxUseDB_Name";
            this.checkBoxUseDB_Name.Size = new System.Drawing.Size(167, 19);
            this.checkBoxUseDB_Name.TabIndex = 6;
            this.checkBoxUseDB_Name.Text = "Use Custom Filename";
            this.checkBoxUseDB_Name.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Custom Filename:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtLogfileName
            // 
            this.txtLogfileName.Location = new System.Drawing.Point(9, 41);
            this.txtLogfileName.Name = "txtLogfileName";
            this.txtLogfileName.Size = new System.Drawing.Size(198, 23);
            this.txtLogfileName.TabIndex = 1;
            this.txtLogfileName.Text = "NOV-xxxxxx_LogFile";
            // 
            // txtTagsPrefix
            // 
            this.txtTagsPrefix.Location = new System.Drawing.Point(9, 293);
            this.txtTagsPrefix.Name = "txtTagsPrefix";
            this.txtTagsPrefix.Size = new System.Drawing.Size(113, 23);
            this.txtTagsPrefix.TabIndex = 1;
            this.txtTagsPrefix.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Step7, Simatic, WinCC && WinCC Flexible are trademarks of SIEMENS";
            // 
            // fetchPLCData
            // 
            this.fetchPLCData.Interval = 300;
            this.fetchPLCData.Tick += new System.EventHandler(this.fetchPLCData_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToolStripFileSystemFolder,
            this.lblStatus,
            this.lblConnInfo,
            this.toolStripStatusLabel1,
            this.lblConnected});
            this.statusStrip.Location = new System.Drawing.Point(0, 641);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip.Size = new System.Drawing.Size(1113, 42);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblToolStripFileSystemFolder
            // 
            this.lblToolStripFileSystemFolder.AutoSize = false;
            this.lblToolStripFileSystemFolder.Name = "lblToolStripFileSystemFolder";
            this.lblToolStripFileSystemFolder.Size = new System.Drawing.Size(600, 37);
            this.lblToolStripFileSystemFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(237, 37);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "i.o.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConnInfo
            // 
            this.lblConnInfo.AutoSize = false;
            this.lblConnInfo.Name = "lblConnInfo";
            this.lblConnInfo.Size = new System.Drawing.Size(230, 37);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 37);
            this.toolStripStatusLabel1.Text = "  ";
            // 
            // lblConnected
            // 
            this.lblConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(19, 37);
            this.lblConnected.Text = "    ";
            // 
            // lstProjects
            // 
            this.lstProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 16;
            this.lstProjects.Location = new System.Drawing.Point(3, 3);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(277, 95);
            this.lstProjects.TabIndex = 24;
            this.lstProjects.DoubleClick += new System.EventHandler(this.lstProjects_DoubleClick);
            // 
            // cmdProjectsBrowser
            // 
            this.cmdProjectsBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdProjectsBrowser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F);
            this.cmdProjectsBrowser.Location = new System.Drawing.Point(286, 3);
            this.cmdProjectsBrowser.Name = "cmdProjectsBrowser";
            this.cmdProjectsBrowser.Size = new System.Drawing.Size(78, 95);
            this.cmdProjectsBrowser.TabIndex = 25;
            this.cmdProjectsBrowser.Text = "Projects\r\nBrowser";
            this.cmdProjectsBrowser.UseVisualStyleBackColor = true;
            this.cmdProjectsBrowser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.attach14ToolStripMenuItem,
            this.attach15_1ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // attach14ToolStripMenuItem
            // 
            this.attach14ToolStripMenuItem.Enabled = false;
            this.attach14ToolStripMenuItem.Name = "attach14ToolStripMenuItem";
            this.attach14ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.attach14ToolStripMenuItem.Text = "Attach V14";
            this.attach14ToolStripMenuItem.Click += new System.EventHandler(this.attachV14_Click);
            // 
            // attach15_1ToolStripMenuItem
            // 
            this.attach15_1ToolStripMenuItem.Enabled = false;
            this.attach15_1ToolStripMenuItem.Name = "attach15_1ToolStripMenuItem";
            this.attach15_1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.attach15_1ToolStripMenuItem.Text = "Attach V15.1";
            this.attach15_1ToolStripMenuItem.Click += new System.EventHandler(this.attachV15_1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertCallsToolStripMenuItem,
            this.mnuExpandDatablockArrays});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // convertCallsToolStripMenuItem
            // 
            this.convertCallsToolStripMenuItem.Enabled = false;
            this.convertCallsToolStripMenuItem.Name = "convertCallsToolStripMenuItem";
            this.convertCallsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.convertCallsToolStripMenuItem.Text = "Convert UCs to Calls";
            this.convertCallsToolStripMenuItem.Click += new System.EventHandler(this.convertCallsToolStripMenuItem_Click);
            // 
            // mnuExpandDatablockArrays
            // 
            this.mnuExpandDatablockArrays.Enabled = false;
            this.mnuExpandDatablockArrays.Name = "mnuExpandDatablockArrays";
            this.mnuExpandDatablockArrays.Size = new System.Drawing.Size(204, 22);
            this.mnuExpandDatablockArrays.Text = "Expand Datablock Arrays";
            this.mnuExpandDatablockArrays.Click += new System.EventHandler(this.mnuExpandDatablockArrays_Click);
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parseAllBlocksToolStripMenuItem,
            this.createAWLToolStripMenuItem});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem1.Text = "Tools";
            // 
            // parseAllBlocksToolStripMenuItem
            // 
            this.parseAllBlocksToolStripMenuItem.Enabled = false;
            this.parseAllBlocksToolStripMenuItem.Name = "parseAllBlocksToolStripMenuItem";
            this.parseAllBlocksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parseAllBlocksToolStripMenuItem.Text = "Parse all Blocks";
            this.parseAllBlocksToolStripMenuItem.Click += new System.EventHandler(this.parseAllBlocksToolStripMenuItem_Click);
            // 
            // createAWLToolStripMenuItem
            // 
            this.createAWLToolStripMenuItem.Enabled = false;
            this.createAWLToolStripMenuItem.Name = "createAWLToolStripMenuItem";
            this.createAWLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createAWLToolStripMenuItem.Text = "Create AWL";
            this.createAWLToolStripMenuItem.Click += new System.EventHandler(this.createAWLToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featuresToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // featuresToolStripMenuItem
            // 
            this.featuresToolStripMenuItem.Enabled = false;
            this.featuresToolStripMenuItem.Name = "featuresToolStripMenuItem";
            this.featuresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.featuresToolStripMenuItem.Text = "Features";
            this.featuresToolStripMenuItem.Click += new System.EventHandler(this.featuresToolStripMenuItem_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(3, 71);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.viewBlockList);
            this.mainSplitContainer.Panel2.Controls.Add(this.datablockView);
            this.mainSplitContainer.Panel2.Controls.Add(this.txtTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.dtaPnPbList);
            this.mainSplitContainer.Panel2.Controls.Add(this.dtaSymbolTable);
            this.mainSplitContainer.Size = new System.Drawing.Size(1107, 543);
            this.mainSplitContainer.SplitterDistance = 373;
            this.mainSplitContainer.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.treeStep7Project, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkShowDeleted, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.Controls.Add(this.lstProjects, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdProjectsBrowser, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 101);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // viewBlockList
            // 
            this.viewBlockList.Controls.Add(this.tableLayoutPanel3);
            this.viewBlockList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBlockList.Location = new System.Drawing.Point(0, 0);
            this.viewBlockList.Name = "viewBlockList";
            this.viewBlockList.Size = new System.Drawing.Size(730, 543);
            this.viewBlockList.TabIndex = 0;
            this.viewBlockList.TabStop = false;
            this.viewBlockList.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelVisu, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(724, 522);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmdSetKnowHow);
            this.flowLayoutPanel1.Controls.Add(this.cmdRemoveKnowHow);
            this.flowLayoutPanel1.Controls.Add(this.cmdUndeleteBlock);
            this.flowLayoutPanel1.Controls.Add(this.txtUndeleteName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 491);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(718, 28);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanelVisu
            // 
            this.tableLayoutPanelVisu.ColumnCount = 2;
            this.tableLayoutPanelVisu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVisu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanelVisu.Controls.Add(this.grpVisu, 1, 0);
            this.tableLayoutPanelVisu.Controls.Add(this.lstListBox, 0, 0);
            this.tableLayoutPanelVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVisu.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelVisu.Name = "tableLayoutPanelVisu";
            this.tableLayoutPanelVisu.RowCount = 1;
            this.tableLayoutPanelVisu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVisu.Size = new System.Drawing.Size(718, 482);
            this.tableLayoutPanelVisu.TabIndex = 12;
            // 
            // datablockView
            // 
            this.datablockView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datablockView.Location = new System.Drawing.Point(0, 0);
            this.datablockView.Name = "datablockView";
            this.datablockView.Size = new System.Drawing.Size(730, 543);
            this.datablockView.TabIndex = 17;
            this.datablockView.Text = "wpfElementHost";
            this.datablockView.Visible = false;
            this.datablockView.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.datablockView.Child = null;
            // 
            // dtaPnPbList
            // 
            this.dtaPnPbList.AllowUserToAddRows = false;
            this.dtaPnPbList.AllowUserToDeleteRows = false;
            this.dtaPnPbList.AllowUserToResizeRows = false;
            this.dtaPnPbList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaPnPbList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtaPnPbList.ContextMenuStrip = this.exportMenu;
            this.dtaPnPbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtaPnPbList.Location = new System.Drawing.Point(0, 0);
            this.dtaPnPbList.Name = "dtaPnPbList";
            this.dtaPnPbList.RowHeadersWidth = 82;
            this.dtaPnPbList.Size = new System.Drawing.Size(730, 543);
            this.dtaPnPbList.TabIndex = 19;
            this.dtaPnPbList.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // exportMenu
            // 
            this.exportMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.exportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.export});
            this.exportMenu.Name = "exportMenu";
            this.exportMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // export
            // 
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(107, 22);
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.mainSplitContainer, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1113, 617);
            this.tableLayoutPanel5.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblProjectName);
            this.panel1.Controls.Add(this.lblProjectInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 62);
            this.panel1.TabIndex = 0;
            // 
            // hexBox
            // 
            this.hexBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox.InfoForeColor = System.Drawing.Color.Empty;
            this.hexBox.Location = new System.Drawing.Point(0, 0);
            this.hexBox.Name = "hexBox";
            this.hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox.Size = new System.Drawing.Size(730, 543);
            this.hexBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1113, 683);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LogFileTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaSymbolTable)).EndInit();
            this.grpVisu.ResumeLayout(false);
            this.grpVisu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.viewBlockList.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanelVisu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaPnPbList)).EndInit();
            this.exportMenu.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectInfo;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TreeView treeStep7Project;
        private System.Windows.Forms.DataGridView dtaSymbolTable;
        private System.Windows.Forms.ListBox lstListBox;
        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.CheckBox chkShowDeleted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSetKnowHow;
        private System.Windows.Forms.Button cmdRemoveKnowHow;
        private System.Windows.Forms.Button cmdUndeleteBlock;
        private System.Windows.Forms.TextBox txtUndeleteName;
        private System.Windows.Forms.GroupBox grpVisu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imglstIconsForTreeview;
        private System.Windows.Forms.TextBox txtTagsPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Integration.ElementHost datablockView;
        private TestProjectFileFunctions.DataBlockViewControl dataBlockViewControl;
        private System.Windows.Forms.Timer fetchPLCData;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblConnInfo;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button cmdProjectsBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attach14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attach15_1ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox viewBlockList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVisu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel lblConnected;
        private System.Windows.Forms.ToolStripStatusLabel lblToolStripFileSystemFolder;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertCallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExpandDatablockArrays;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private Be.Windows.Forms.HexBox hexBox;
        private System.Windows.Forms.ToolStripMenuItem parseAllBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAWLToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtaPnPbList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip exportMenu;
        private System.Windows.Forms.ToolStripMenuItem export;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn datatype;
        private System.Windows.Forms.DataGridViewTextBoxColumn operand;
        private System.Windows.Forms.DataGridViewTextBoxColumn operandiec;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn tia_key;
        private System.Windows.Forms.TextBox txtLogfileName;
        private System.Windows.Forms.CheckBox checkBoxUseDB_Name;
        private System.Windows.Forms.Button buttonFastLogAWL;
        private System.Windows.Forms.Button buttonCreateLogFile;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxMPI;
        private System.Windows.Forms.TextBox textBoxSlot;
        private System.Windows.Forms.TextBox textBoxRack;
        private System.Windows.Forms.CheckBox checkBoxOpenTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

