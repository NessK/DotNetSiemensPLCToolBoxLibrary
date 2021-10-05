using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using DotNetSiemensPLCToolBoxLibrary.Communication;
using DotNetSiemensPLCToolBoxLibrary.DataTypes;
using DotNetSiemensPLCToolBoxLibrary.DataTypes.AWL.Step7V5;
using DotNetSiemensPLCToolBoxLibrary.DataTypes.Blocks;
using DotNetSiemensPLCToolBoxLibrary.DataTypes.Blocks.Step7V5;
using DotNetSiemensPLCToolBoxLibrary.DataTypes.Hardware.Step7V5;
using DotNetSiemensPLCToolBoxLibrary.DataTypes.Projectfolders;
using DotNetSiemensPLCToolBoxLibrary.DataTypes.Projectfolders.Step7V5;
using DotNetSiemensPLCToolBoxLibrary.General;
using DotNetSiemensPLCToolBoxLibrary.Projectfiles;
using TestProjectFileFunctions;
using System.Text.RegularExpressions;
using ToolboxForSiemensPLCs;
using ToolboxForSiemensPLCs.Properties;

using Application = System.Windows.Forms.Application;
using Color = System.Drawing.Color;
using ContextMenu = System.Windows.Forms.ContextMenu;
using MenuItem = System.Windows.Forms.MenuItem;
using MessageBox = System.Windows.Forms.MessageBox;
using DotNetSiemensPLCToolBoxLibrary.DataTypes.Blocks.Step5;
using DotNetSiemensPLCToolBoxLibrary.DataTypes.Projectfolders.Step5;

namespace JFK_VarTab
{
    public partial class Form1 : Form
    {

        string CPU_Slot = "2";
        string CPU_Rack = "0";
        string CPU_MPI = "2";
        string CP_IP = "192.168.10.107";

        public Form1()
        {
            InitializeComponent();
            this.dataBlockViewControl = new TestProjectFileFunctions.DataBlockViewControl();
            this.datablockView.Child = this.dataBlockViewControl;
            treeStep7Project.AllowDrop = true;
            treeStep7Project.DragDrop += TreeStep7Project_DragDrop;
            treeStep7Project.DragOver += TreeStep7Project_DragOver;

        }

        private void TreeStep7Project_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = System.Windows.Forms.DragDropEffects.All;
        }

        private void TreeStep7Project_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            var dropped = ((string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop));
            var files = dropped.ToList();
            foreach (var file in files)
            {
                loadPrj(file);
            }
        }

        private Step7ProjectV5 tmp;

        private void Form1_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    if (Settings.Default.OpenedProjects != null)
            //        foreach (string prj in Settings.Default.OpenedProjects)
            //        {
            //            loadPrj(prj);
            //        }
            //}
            //catch (Exception ex)
            //{
            //    lblStatus.Text = ex.Message;
            //}


            if (!string.IsNullOrEmpty(Settings.Default.ProjectsPath))
            {
                lstProjects.Items.Clear();
                lstProjects.Items.AddRange(Projects.GetStep7ProjectsFromDirectory(Settings.Default.ProjectsPath));
            }

        }

        private class myTreeNode : TreeNode
        {
            public object myObject;
        }

        public void AddNodes(TreeNode nd, List<ProjectFolder> lst)
        {

            foreach (var subitem in lst)
            {
                myTreeNode tmpNode = new myTreeNode();
                tmpNode.Text = subitem.Name;
                tmpNode.myObject = subitem;
                tmpNode.ImageIndex = 0;
                //nd.ImageKey
                //Set the Image for the Folders...

                if (subitem.GetType() == typeof(StationConfigurationFolder))
                {
                    if (((StationConfigurationFolder)subitem).StationType == PLCType.Simatic300)
                        tmpNode.ImageIndex = 4;

                    else if (((StationConfigurationFolder)subitem).StationType == PLCType.Simatic400 ||
                             ((StationConfigurationFolder)subitem).StationType == PLCType.Simatic400H)

                        tmpNode.ImageIndex = 5;
                }
                else if (subitem.GetType() == typeof(CPUFolder))
                {
                    if (((CPUFolder)subitem).CpuType == PLCType.Simatic300) tmpNode.ImageIndex = 2;
                    else if (((CPUFolder)subitem).CpuType == PLCType.Simatic400 ||
                             ((CPUFolder)subitem).CpuType == PLCType.Simatic400H) tmpNode.ImageIndex = 3;
                }

                nd.Nodes.Add(tmpNode);

                if (subitem.SubItems != null) AddNodes(tmpNode, subitem.SubItems);
            }
        }

        Credentials credentials;

        private void loadPrj(string fnm)
        {
            if (fnm != "")
            {
                /*
                dtaSymbolTable.Visible = false;
                lstListBox.Visible = false;
                txtTextBox.Visible = false;
                cmdSetKnowHow.Visible = false;
                cmdRemoveKnowHow.Visible = false;
                cmdUndeleteBlock.Visible = false;
                txtUndeleteName.Visible = false;
                */
                //treeStep7Project.Nodes.Clear();

                Project tmp = Projects.LoadProject(fnm, chkShowDeleted.Checked, credentials);
                LoadProject(tmp);
                //tmp = new Step7ProjectV5(fnm, chkShowDeleted.Checked);

                //listBox1.Items.AddRange(tmp.PrgProjectFolders.ToArray());
                //lblProjectName.Text = tmp.ProjectName;
                //lblProjectInfo.Text = tmp.ProjectDescription;




            }
        }

        private void attachV14_Click(object sender, EventArgs e)
        {
            var prj = Projects.AttachProject("14SP1");
            LoadProject(prj);
        }

        private void attachV15_1_Click(object sender, EventArgs e)
        {
            var prj = Projects.AttachProject("15.1");
            LoadProject(prj);
        }

        private void LoadProject(Project prj)
        {
            if (prj != null)
            {
                myTreeNode trnd = new myTreeNode();
                trnd.myObject = prj.ProjectStructure;
                trnd.Text = prj.ToString();
                if (chkShowDeleted.Checked) trnd.Text += "(show deleted)";
                if (prj.ProjectStructure != null) AddNodes(trnd, prj.ProjectStructure.SubItems);
                treeStep7Project.Nodes.Add(trnd);
            }
        }

        private IBlocksFolder blkFld;

        private SourceFolder src;

        private TreeNode oldNode;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (myConn != null) myConn.Disconnect();

            viewBlockList.Visible = false;

            dtaSymbolTable.Visible = false;

            hexBox.Visible = false;

            txtTextBox.Visible = false;
            lblToolStripFileSystemFolder.Text = "";

            lblStatus.Text = "";

            tableLayoutPanelVisu.ColumnStyles[1].Width = 0;

            datablockView.Visible = false;
            dtaPnPbList.Visible = false;

            lblToolStripFileSystemFolder.Text = "";

            blkFld = null;


            if (treeStep7Project.SelectedNode != null)
            {
                ProjectFolder fld = (ProjectFolder)((myTreeNode)treeStep7Project.SelectedNode).myObject;
                lblProjectName.Text = fld.Project.ProjectName;
                lblProjectInfo.Text = fld.Project.ProjectDescription;


                var tmp = (myTreeNode)treeStep7Project.SelectedNode;
                if (tmp.myObject is IBlocksFolder)
                    blkFld = (IBlocksFolder)tmp.myObject;

                if (tmp.myObject is ISymbolTable)
                {
                    var tmp2 = (ISymbolTable)tmp.myObject;

                    if (oldNode != treeStep7Project.SelectedNode)
                    {

                        dtaSymbolTable.Rows.Clear();
                        foreach (var step7SymbolTableEntry in tmp2.SymbolTableEntrys)
                        {
                            //var tiaRow = step7SymbolTableEntry as TIASymbolTableEntry;
                            //if (tiaRow != null)
                            //{
                            //    dtaSymbolTable.Rows.Add(new object[]
                            //    {
                            //        step7SymbolTableEntry.Symbol, step7SymbolTableEntry.DataType,
                            //        step7SymbolTableEntry.Operand, step7SymbolTableEntry.OperandIEC,
                            //        step7SymbolTableEntry.Comment, tiaRow.TIATagAccessKey
                            //    });
                            //}
                            //else
                            {
                                dtaSymbolTable.Rows.Add(new object[]
                                {
                                    step7SymbolTableEntry.Symbol, step7SymbolTableEntry.DataType,
                                    step7SymbolTableEntry.Operand, step7SymbolTableEntry.OperandIEC,
                                    step7SymbolTableEntry.Comment
                                });
                            }
                        }
                    }
                    dtaSymbolTable.Visible = true;
                    lblToolStripFileSystemFolder.Text = tmp2.Folder;
                }
                else if (tmp.myObject is MasterSystem)
                {
                    var tmp2 = (MasterSystem)tmp.myObject;

                    if (oldNode != treeStep7Project.SelectedNode)
                    {

                        dtaPnPbList.Rows.Clear();
                        foreach (var s in tmp2.Children)
                        {
                            dtaPnPbList.Rows.Add(new object[] { s.NodeId, s.Name, });
                        }
                    }
                    dtaPnPbList.Visible = true;
                }
                else if (blkFld != null)
                {
                    if (oldNode != treeStep7Project.SelectedNode)
                    {
                        lstListBox.Items.Clear();
                        //ProjectBlockInfo[] arr = 
                        //NumericComparer nc = new NumericComparer();
                        //Array.Sort(arr, nc);
                        lstListBox.Items.AddRange(blkFld.readPlcBlocksList().ToArray());
                    }
                    viewBlockList.Visible = true;

                    if (tmp.myObject.GetType() == typeof(BlocksOfflineFolder))
                        lblToolStripFileSystemFolder.Text = ((BlocksOfflineFolder)blkFld).Folder;
                }
                //else if (tmp.myObject is TIAProjectFolder)
                //{
                //    var afld = tmp.myObject as TIAProjectFolder;
                //    if (oldNode != treeStep7Project.SelectedNode)
                //    {
                //        lstListBox.Items.Clear();
                //        //lstListBox.Items.Add("ID: " + afld.ID);
                //        //lstListBox.Items.Add("InstID: " + afld.InstID);

                //    }
                //    viewBlockList.Visible = true;
                //}
                else if (tmp.myObject.GetType() == typeof(SourceFolder))
                {
                    src = (SourceFolder)tmp.myObject;
                    if (oldNode != treeStep7Project.SelectedNode)
                    {
                        lstListBox.Items.Clear();
                        lstListBox.Items.AddRange(src.readPlcBlocksList().ToArray());
                    }
                    viewBlockList.Visible = true;

                    lblToolStripFileSystemFolder.Text = src.Folder;
                }
                else if (tmp.myObject is CPUFolder)
                {
                    var cp = tmp.myObject as CPFolder; // Sneaky Sneaky pick up IP Address from CP Folder             

                    var cpu = tmp.myObject as CPUFolder;

                    //Get CPU Slot, Rack
                    CPU_Slot = cpu.Slot.ToString();
                    CPU_Rack = cpu.Rack.ToString();

                    //Slot
                    textBoxSlot.Text = CPU_Slot;

                    //Rack
                    textBoxRack.Text = CPU_Rack;


                    if (oldNode != treeStep7Project.SelectedNode)
                    {
                        lstListBox.Items.Clear();
                        lstListBox.Items.Add("Password: " + cpu.PasswdHard);
                        lstListBox.Items.Add("CpuType: " + cpu.CpuType);

                        if (cpu.NetworkInterfaces != null)
                        {
                            foreach (var networkInterface in cpu.NetworkInterfaces)
                            {
                                lstListBox.Items.Add("Network-Interface: " + networkInterface.ToString());
                            }
                            foreach (string line in lstListBox.Items) // Pick Up DP or MPI Address from CPU.
                            {
                                if (Regex.IsMatch(line, @"\bMPI|\bDP")) //Separer ut kun linjer som inneholder MPI 
                                {
                                    string line2 = "";
                                    line2 = Regex.Replace(line, "[^0-9.]", "");
                                    CPU_MPI = line2;
                                    textBoxMPI.Text = CPU_MPI;
                                }
                            }
                        }
                    }
                    viewBlockList.Visible = true;
                }
                else if (tmp.myObject is CPFolder)
                {
                    var cp = tmp.myObject as CPFolder;
                    if (oldNode != treeStep7Project.SelectedNode)
                    {
                        lstListBox.Items.Clear();
                        var rd = new StringReader(cp.ToString());
                        string line = null;
                        while ((line = rd.ReadLine()) != null)

                        {
                            lstListBox.Items.Add(line);
                        }
                        foreach (string linez in lstListBox.Items) // Pick Up DP or MPI Address from CPU.
                        {
                            if (Regex.IsMatch(linez, @"((?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?\.){3}(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)))")) //Separer ut kun linjer som inneholder MPI 
                            {
                                string IP = "";
                                IP = Regex.Replace(linez, "^.*(?=\\b192)", "");
                                CP_IP = IP;
                                textBoxIP.Text = CP_IP;                             
                            }
                        }
                    }
                    viewBlockList.Visible = true;
                }
            }
            oldNode = treeStep7Project.SelectedNode;
        }

        private IDataBlock myBlk = null;

        private S7DataRow expRow = null;

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (lstListBox.SelectedItem == null)
                return;

            viewBlockList.Visible = false;

            if (lstListBox.SelectedItem is ProjectBlockInfo)
            {
                viewBlockList.Visible = false;

                lblStatus.Text = ((ProjectBlockInfo)lstListBox.SelectedItem).ToString();
                
                Block tmp;
                if (blkFld is BlocksOfflineFolder)
                    tmp = ((BlocksOfflineFolder)blkFld).GetBlock((ProjectBlockInfo)lstListBox.SelectedItem,
                        new S7ConvertingOptions(MnemonicLanguage.German)
                        {
                            GenerateCallsfromUCs = convertCallsToolStripMenuItem.Checked
                        });
                else tmp = blkFld.GetBlock((ProjectBlockInfo)lstListBox.SelectedItem);

                if (tmp != null)
                {
                    if (tmp.BlockType == PLCBlockType.UDT || tmp.BlockType == PLCBlockType.DB ||
                        tmp.BlockType == PLCBlockType.S5_DV || tmp.BlockType == PLCBlockType.S5_DB)
                    {
                        //dataBlockViewControl.DataBlockRows = ((PLCDataBlock) tmp).Structure;
                        myBlk = (IDataBlock)tmp;
                        //expRow = myBlk.Structure;
                        //if (mnuExpandDatablockArrays.Checked)
                        //    expRow = myBlk.GetArrayExpandedStructure(new S7DataBlockExpandOptions() { ExpandCharArrays = false });

                        checkBox1.Checked = mnuExpandDatablockArrays.Checked;
                        dataBlockViewControl.ExpandDataBlockArrays = mnuExpandDatablockArrays.Checked;
                        dataBlockViewControl.DataBlock = myBlk;

                        datablockView.Visible = true;

                    }
                    else
                    {
                        txtTextBox.Text = tmp.ToString();
                        txtTextBox.Visible = true;
                    }
                }

            }
            else if (lstListBox.SelectedItem.GetType() == typeof(S7ProjectSourceInfo))
            {
                var tmp = (S7ProjectSourceInfo)lstListBox.SelectedItem;

                if (tmp != null)
                {
                    string fnm = tmp.Filename;

                    if (fnm != null && fnm != "")
                        if (System.IO.File.Exists(fnm))
                            txtTextBox.Text = new System.IO.StreamReader(tmp.Filename).ReadToEnd();
                }

                txtTextBox.Visible = true;
                //lstListBox.Visible = false;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListBox.SelectedItem != null)
                if (lstListBox.SelectedItem.GetType() == typeof(S7ProjectBlockInfo))
                {
                    var tmp = (S7ProjectBlockInfo)lstListBox.SelectedItem;
                    if (tmp.BlockType == PLCBlockType.DB) tableLayoutPanelVisu.ColumnStyles[1].Width = 255;
                    //grpVisu.Visible = true;
                    else
                        //grpVisu.Visible = false;
                        tableLayoutPanelVisu.ColumnStyles[1].Width = 0;
                    if (!tmp.Deleted)
                    {
                        cmdUndeleteBlock.Visible = false;
                        txtUndeleteName.Visible = false;
                    }
                    else
                    {
                        //cmdUndeleteBlock.Visible = true;
                        //txtUndeleteName.Visible = true;
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstListBox.SelectedItem != null)
                if (lstListBox.SelectedItem.GetType() == typeof(S7ProjectBlockInfo))
                {
                    ((BlocksOfflineFolder)blkFld).ChangeKnowHowProtection(
                        (S7ProjectBlockInfo)lstListBox.SelectedItem, true);
                    lstListBox.Items.Clear();
                    lstListBox.Items.AddRange(blkFld.readPlcBlocksList().ToArray());
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstListBox.SelectedItem != null)
                if (lstListBox.SelectedItem.GetType() == typeof(S7ProjectBlockInfo))
                {
                    ((BlocksOfflineFolder)blkFld).ChangeKnowHowProtection(
                        (S7ProjectBlockInfo)lstListBox.SelectedItem, false);
                    lstListBox.Items.Clear();
                    lstListBox.Items.AddRange(blkFld.readPlcBlocksList().ToArray());
                }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //This Button is not showed, because it does not work.
            //After undeleteion of a Block you have to recreate the mdx File of the database, and this needs to be implemented
            if (lstListBox.SelectedItem != null)
                if (lstListBox.SelectedItem.GetType() == typeof(S7ProjectBlockInfo))
                {
                    ((BlocksOfflineFolder)blkFld).UndeleteBlock((S7ProjectBlockInfo)lstListBox.SelectedItem,
                        Convert.ToInt32(txtUndeleteName.Text));
                    treeView1_AfterSelect(sender, null);
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            if (treeStep7Project.SelectedNode != null) treeView1_AfterSelect(sender, null);
        }



        private void treeStep7Project_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.ImageIndex == 1) e.Node.ImageIndex = 0;
        }

        private void treeStep7Project_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.ImageIndex == 0) e.Node.ImageIndex = 1;
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private PLCConnection myConn;
        


        private List<PLCTag> valueList = null;

        private ScrollViewer myScrollViewer = null;

        private int oldPos = 0;

        private void fetchPLCData_Tick(object sender, EventArgs e)
        {
            if (lblConnected.BackColor == Color.LightGreen) lblConnected.BackColor = Color.DarkGray;
            else lblConnected.BackColor = Color.LightGreen;

            try
            {
                if (myConn.Connected)
                {


                    /* Get the ScrollViewer des XAML Trees (um scrollposition zu lesen!)... */
                    if (myScrollViewer == null)
                    {
                        DependencyObject tst = VisualTreeHelper.GetChild(dataBlockViewControl.MyTree, 0);
                        while (tst != null && tst.GetType() != typeof(ScrollViewer))
                        {
                            tst = VisualTreeHelper.GetChild(tst, 0);
                        }
                        if (tst != null)
                        {
                            myScrollViewer = (ScrollViewer)tst;

                        }
                    }

                    //nur die angezeigten Values von der SPS lesen...
                    int start = (int)myScrollViewer.VerticalOffset / 20;
                    if (valueList == null || start != oldPos)
                    {
                        List<S7DataRow> tmpLst = S7DataRow.GetChildrowsAsList(expRow).Cast<S7DataRow>().ToList();
                        List<S7DataRow> askLst = new List<S7DataRow>();
                        for (int n = 0; n < tmpLst.Count; n++)
                        {
                            if (n >= start && n < start + 24)
                            {
                                askLst.Add(tmpLst[n]);
                            }
                        }
                        valueList = S7DataRow.GetLibnoDaveValues(askLst);
                        oldPos = start;
                    }
                    myConn.ReadValues(valueList);
                }
                else
                {
                    oldPos = 0;
                    myScrollViewer = null;
                    fetchPLCData.Enabled = false;
                    valueList = null;
                    lblConnected.BackColor = Color.DarkGray;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }


        private void lstListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') listBox1_DoubleClick(sender, null);
        }



        private void cmdCloseProject_Click(object sender, EventArgs e)
        {
            if (treeStep7Project.SelectedNode != null)
            {
                myTreeNode nd = (myTreeNode)treeStep7Project.SelectedNode;
                while (nd.Parent != null)
                {
                    nd = (myTreeNode)nd.Parent;
                }
                treeStep7Project.Nodes.Remove(nd);

                var fld = nd.myObject as IProjectFolder;
                if (fld != null)
                {
                    var dp = fld.Project as IDisposable;
                    if (dp != null)
                    {
                        dp.Dispose();
                    }
                }
            }

            List<string> projects = new List<string>();
            foreach (myTreeNode myTreeNode in treeStep7Project.Nodes)
            {
                projects.Add(((ProjectFolder)myTreeNode.myObject).Project.ProjectFile);
            }

            var col = new StringCollection();
            col.AddRange(projects.ToArray());
            Settings.Default.OpenedProjects = col;
            Settings.Default.Save();

        }

        private void chkShowDeleted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowDeleted.Checked)
                MessageBox.Show("After checking this checkbox please reopen the project to show deleted blocks!");
        }

        private void treeStep7Project_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeStep7Project.ContextMenu =
                    new ContextMenu(new MenuItem[]
                    {new MenuItem("Close", delegate { cmdCloseProject_Click(sender, null); }),});
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDlg = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(Settings.Default.ProjectsPath))
                fldDlg.SelectedPath = Settings.Default.ProjectsPath;
            fldDlg.ShowNewFolderButton = false;
            DialogResult ret = fldDlg.ShowDialog();


            if (ret == DialogResult.OK)
            {
                lstProjects.Items.Clear();
                Settings.Default.ProjectsPath = fldDlg.SelectedPath;
                Settings.Default.Save();
                lstProjects.Items.AddRange(Projects.GetStep7ProjectsFromDirectory(fldDlg.SelectedPath));
            }
        }

        private void lstProjects_DoubleClick(object sender, EventArgs e)
        {
            if (lstProjects.SelectedItem != null)
            {
                Project tmp = (Project)lstProjects.SelectedItem;
                loadPrj(tmp.ProjectFile);
            }

            List<string> projects = new List<string>();
            foreach (myTreeNode myTreeNode in treeStep7Project.Nodes)
            {
                projects.Add(((ProjectFolder)myTreeNode.myObject).Project.ProjectFile);
            }

            var col = new StringCollection();
            col.AddRange(projects.ToArray());
            Settings.Default.OpenedProjects = col;
            Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void featuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Features()).ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All supported types (*.zip, *.s7p, *.s5d, *.ap11, *.ap12, *.ap13; *.ap14; *.ap15; *.ap15_1; *.ap16; *.al11; *.al12; *.al13; *.al14; *.al15; *.al15_1; *.al16; *.zap13; *.zap14; *.zap15; *.zap15_1; *.zap16)|*.s7p;*.zip;*.s5d;*.s7l;*.ap11;*.ap12;*.ap13;*.ap14;*.ap14;*.ap15_1;*.al11;*.al12;*.al13;*.al14;*.al15;*.al15_1;*.zap13;*.zap14;*.zap15;*.zap15_1|Step5 Project|*.s5d|Step7 V5.5 Project|*.s7p;*.s7l|Zipped Step5/Step7 Project|*.zip|TIA-Portal Project|*.ap11;*.ap12;*.ap13;*.ap14;*.ap15;*.ap15_1;*.al11;*.al12;*.al13;*.al14;*.al15;*.al15_1;*.al16;*.zap13;*.zap14;*.zap15;*.zap15_1; *.zap16";
            op.CheckFileExists = false;
            op.ValidateNames = false;
            var ret = op.ShowDialog();
            if (ret == DialogResult.OK)
            {
                loadPrj(op.FileName);
            }

            List<string> projects = new List<string>();
            foreach (myTreeNode myTreeNode in treeStep7Project.Nodes)
            {
                projects.Add(((ProjectFolder)myTreeNode.myObject).Project.ProjectFile);
            }

            var col = new StringCollection();
            col.AddRange(projects.ToArray());
            Settings.Default.OpenedProjects = col;
            Settings.Default.Save();
        }

        private void unwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblConnected.BackColor = Color.DarkGray;
            if (myConn != null && myConn.Connected) myConn.Disconnect();
        }

        private void mnuExpandDatablockArrays_Click(object sender, EventArgs e)
        {
            if (mnuExpandDatablockArrays.Checked) mnuExpandDatablockArrays.Checked = false;
            else mnuExpandDatablockArrays.Checked = true;
            unwatchToolStripMenuItem_Click(sender, e);

            dataBlockViewControl.ExpandDataBlockArrays = mnuExpandDatablockArrays.Checked;

            //expRow = myBlk.Structure;
            //if (mnuExpandDatablockArrays.Checked)
            //expRow = myBlk.GetArrayExpandedStructure(new S7DataBlockExpandOptions() { ExpandCharArrays = false });
            //dataBlockViewControl.DataBlock = myBlk;
        }

        private void treeStep7Project_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeStep7Project.SelectedNode = e.Node;
                treeView1_AfterSelect(sender, null);
            }
        }

        private void convertCallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            convertCallsToolStripMenuItem.Checked = !convertCallsToolStripMenuItem.Checked;
        }

        private void dBStructResizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBStructresizer stRz = new DBStructresizer();
            stRz.ShowDialog();
        }


        

        private void buttonCreateLogFile_Click(object sender, EventArgs e) //Kenneth
          
        {

            S7DataBlock myDB =
                (S7DataBlock) ((BlocksOfflineFolder) blkFld).GetBlock((S7ProjectBlockInfo) lstListBox.SelectedItem);

            List<DataBlockRow> myLst = null;
            myLst = S7DataRow.GetChildrowsAsList(((S7DataRow) myDB.Structure)); // myDB.GetRowsAsList();

            string tags = "";
            string temptags = "";
            if (myDB.IsInstanceDB)
            { 
            
            foreach (S7DataRow plcDataRow in myLst) // myDB.GetRowsAsList())
            {
                string tagName = txtTagsPrefix.Text +
                                 plcDataRow.StructuredName;
                

                switch (plcDataRow.DataType)
                {
                    case S7DataRowType.BOOL:
                        temptags += myDB.SymbolOrName + "." + plcDataRow.StructuredName + ";" + myDB.BlockNumber + ";" +
                                plcDataRow.BlockAddress.ByteAddress.ToString() + ";" + "1" + ";" +
                                plcDataRow.BlockAddress.BitAddress.ToString() + "\r\n";
                        tags = temptags.Replace(".STATIC.", ".");
                        break;
                    case S7DataRowType.INT:
                    
                        break;
                    case S7DataRowType.DINT:
                        break;
                                                
                    case S7DataRowType.WORD:
                       
                        break;
                    case S7DataRowType.DWORD:
                        
                        break;
                    case S7DataRowType.BYTE:
                     
                        break;
                    case S7DataRowType.REAL:
                        temptags += myDB.SymbolOrName + "." + plcDataRow.StructuredName + ";" + myDB.BlockNumber + ";" +
                                plcDataRow.BlockAddress.ByteAddress.ToString() + ";" + "2" + ";" +
                                "0" + "\r\n";
                        tags = temptags.Replace(".STATIC.", ".");
                        break;
                    case S7DataRowType.CHAR:
                        
                        break;
                    case S7DataRowType.COUNTER:
                   
                        break;
                    case S7DataRowType.DATE:
                        
                        break;
                    case S7DataRowType.DATE_AND_TIME:
                        
                        break;
                    case S7DataRowType.S5TIME:
                     
                        break;
                    case S7DataRowType.STRING:
                       
                        break;
                    case S7DataRowType.TIME:
                        
                        break;
                    case S7DataRowType.TIME_OF_DAY:
                       
                        break;
                    case S7DataRowType.TIMER:
                        
                        break;
                }
            }
            }
            else
            {
                foreach (S7DataRow plcDataRow in myLst) // myDB.GetRowsAsList())
                {
                    string tagName = txtTagsPrefix.Text +
                                     plcDataRow.StructuredName;


                    switch (plcDataRow.DataType)
                    {
                        case S7DataRowType.BOOL:
                            tags += myDB.SymbolOrName + "." + plcDataRow.StructuredName + ";" + myDB.BlockNumber + ";" +
                                    plcDataRow.BlockAddress.ByteAddress.ToString() + ";" + "1" + ";" +
                                    plcDataRow.BlockAddress.BitAddress.ToString() + "\r\n";
                            break;
                        case S7DataRowType.INT:

                            break;
                        case S7DataRowType.DINT:
                            break;

                        case S7DataRowType.WORD:

                            break;
                        case S7DataRowType.DWORD:

                            break;
                        case S7DataRowType.BYTE:

                            break;
                        case S7DataRowType.REAL:
                            tags += myDB.SymbolOrName + "." + plcDataRow.StructuredName + ";" + myDB.BlockNumber + ";" +
                                    plcDataRow.BlockAddress.ByteAddress.ToString() + ";" + "2" + ";" +
                                    "0" + "\r\n";
                            break;
                        case S7DataRowType.CHAR:

                            break;
                        case S7DataRowType.COUNTER:

                            break;
                        case S7DataRowType.DATE:

                            break;
                        case S7DataRowType.DATE_AND_TIME:

                            break;
                        case S7DataRowType.S5TIME:

                            break;
                        case S7DataRowType.STRING:

                            break;
                        case S7DataRowType.TIME:

                            break;
                        case S7DataRowType.TIME_OF_DAY:

                            break;
                        case S7DataRowType.TIMER:

                            break;
                    }
                }
            }
            string filename = "";
            if (checkBoxUseDB_Name.Checked)
                {
                filename = txtLogfileName.Text;
                }
                else
                {
                filename = myDB.SymbolOrName + "_LogFile";
                }

            FolderBrowserDialog fldDlg = null;

            fldDlg = new FolderBrowserDialog();
            fldDlg.Description = "Destination Directory for Tags.csv!";
            if (fldDlg.ShowDialog() == DialogResult.OK)
            {
                                            
                System.IO.StreamWriter swr;

                swr = new System.IO.StreamWriter(fldDlg.SelectedPath + "\\" + filename + ".txt");
                swr.WriteLine("#" + CPU_MPI + ";" + CPU_Slot); //Write the first two lines
                swr.WriteLine("@" + CPU_Rack + ";" + CP_IP);
                swr.Write(tags.Replace("\t", ";"));
                swr.Close();
                if (checkBoxOpenTxt.Checked)
                {
                    System.Diagnostics.Process.Start(fldDlg.SelectedPath + "\\" + filename + ".txt");
                }
                
            }
        }
  
        private void parseAllBlocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try to parse all Blocks");
            foreach (var item in lstListBox.Items)
            {
                if (item is ProjectBlockInfo)
                {
                    Block tmp;
                    if (blkFld is BlocksOfflineFolder)
                        tmp = ((BlocksOfflineFolder) blkFld).GetBlock((ProjectBlockInfo) item,
                            new S7ConvertingOptions(MnemonicLanguage.German)
                            {
                                GenerateCallsfromUCs = convertCallsToolStripMenuItem.Checked
                            });
                    else tmp = blkFld.GetBlock((ProjectBlockInfo) lstListBox.SelectedItem);
                }
            }
            MessageBox.Show("Finished parse all Blocks");
        }

        private void createAWLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();


            if (fld.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var item in lstListBox.Items)
                {
                    if (item is S7ProjectBlockInfo)
                    {
                        var nm = ((S7ProjectBlockInfo) item).BlockName;
                        if ((((S7ProjectBlockInfo) item).SymbolTabelEntry != null))
                            nm = ((S7ProjectBlockInfo) item).SymbolTabelEntry.Symbol;

                        nm = nm.Replace("\\", "_")
                            .Replace("/", "_")
                            .Replace(" ", "_")
                            .Replace("-", "_")
                            .Replace(":", "_");
                        nm += ".awl";

                        StreamWriter wrt = new StreamWriter(fld.SelectedPath + "\\" + nm, false,
                            Encoding.GetEncoding("ISO-8859-1"));
                        wrt.Write(((S7ProjectBlockInfo) item).GetSourceBlock());
                        wrt.Close();
                    }
                }
            }
        }   

        private string CreateHirachy(string prefix, S7FunctionBlock block, Stack<string> parentBlocks)
        {
            string spacer = "  |   ";
            parentBlocks.Push(block.BlockName);

            string retVal = "";
            if (prefix != "")
                retVal += prefix.Substring(0, prefix.Length - 3) + "---" + block.BlockName + Environment.NewLine;
            else
                retVal += block.BlockName + Environment.NewLine;
            //foreach (var calledBlock in block.CalledBlocks)
            foreach (var calledBlock in block.CalledBlocks.Distinct())
            {
                var fld = block.ParentFolder as BlocksOfflineFolder;
                var blk = fld.GetBlock(calledBlock) as S7FunctionBlock;

                if (blk != null)
                {
                    if (!parentBlocks.Contains(blk.BlockName))
                    {
                        retVal += CreateHirachy(prefix + spacer, blk, parentBlocks);
                    }
                    else
                    {
                        retVal += prefix + spacer.Substring(0,3) + "---" + blk.BlockName + " (recursive)" + Environment.NewLine;
                    }
                }
            }

            parentBlocks.Pop();

            return retVal;
        }

        private string CreateHirachy(string prefix, S5FunctionBlock block, Stack<string> parentBlocks)
        {
            string spacer = "  |   ";
            parentBlocks.Push(block.BlockName);

            string retVal = "";
            if (prefix != "")
                retVal += prefix.Substring(0, prefix.Length - 3) + "---" + block.BlockName + Environment.NewLine;
            else
                retVal += block.BlockName + Environment.NewLine;
            //foreach (var calledBlock in block.CalledBlocks)
            foreach (var calledBlock in block.CalledBlocks.Distinct())
            {
                var fld = block.ParentFolder as Step5BlocksFolder;
                var blk = fld.GetBlock(calledBlock) as S5FunctionBlock;

                if (blk != null)
                {
                    if (!parentBlocks.Contains(blk.BlockName))
                    {
                        retVal += CreateHirachy(prefix + spacer, blk, parentBlocks);
                    }
                    else
                    {
                        retVal += prefix + spacer.Substring(0, 3) + "---" + blk.BlockName + " (recursive)" + Environment.NewLine;
                    }
                }
            }

            parentBlocks.Pop();

            return retVal;
        }     
        
        private void export_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string tx = "";
                foreach (DataGridViewRow dataRow in dtaPnPbList.Rows)
                {
                    tx += dataRow.Cells[0].Value + ";\"" + dataRow.Cells[1].Value + "\"" + Environment.NewLine;
                }
                using (StreamWriter outfile = new StreamWriter(dlg.FileName))
                {

                    outfile.Write(tx);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

    public class WEBfactoryTag
    {
        public string SignalName;

        public string OPCItemName;

        public string Description;

        public static string GetHeader()
        {
            return "SignalName;OPC Item Name;Description\r\n";
        }

        public override string ToString()
        {
            return SignalName + ";" + OPCItemName + ";" + Description + "\r\n";
        }
    }

}
