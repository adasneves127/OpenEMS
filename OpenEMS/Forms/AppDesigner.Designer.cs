namespace OpenEMS;

partial class AppDesigner
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDesigner));
        statusStrip1 = new StatusStrip();
        menuStrip1 = new MenuStrip();
        viewToolStripMenuItem = new ToolStripMenuItem();
        insertToolStripMenuItem = new ToolStripMenuItem();
        buildToolStripMenuItem = new ToolStripMenuItem();
        debugToolStripMenuItem = new ToolStripMenuItem();
        goToolStripMenuItem = new ToolStripMenuItem();
        windowToolStripMenuItem = new ToolStripMenuItem();
        splitContainer1 = new SplitContainer();
        splitContainer2 = new SplitContainer();
        tabControl1 = new TabControl();
        tab_Dev = new TabPage();
        DevelopmentTreeView = new TreeView();
        tab_Upgrade = new TabPage();
        UpgradeTreeView = new TreeView();
        groupBox1 = new GroupBox();
        openFilesTC = new TabControl();
        tabControl2 = new TabControl();
        tabPage3 = new TabPage();
        tabPage4 = new TabPage();
        tabPage5 = new TabPage();
        tabPage6 = new TabPage();
        fileToolStripMenuItem1 = new ToolStripMenuItem();
        newToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator = new ToolStripSeparator();
        saveToolStripMenuItem = new ToolStripMenuItem();
        saveAsToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        printToolStripMenuItem = new ToolStripMenuItem();
        printPreviewToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        exitToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem1 = new ToolStripMenuItem();
        undoToolStripMenuItem = new ToolStripMenuItem();
        redoToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        cutToolStripMenuItem = new ToolStripMenuItem();
        copyToolStripMenuItem = new ToolStripMenuItem();
        pasteToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        selectAllToolStripMenuItem = new ToolStripMenuItem();
        toolsToolStripMenuItem1 = new ToolStripMenuItem();
        customizeToolStripMenuItem = new ToolStripMenuItem();
        optionsToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem1 = new ToolStripMenuItem();
        contentsToolStripMenuItem = new ToolStripMenuItem();
        indexToolStripMenuItem = new ToolStripMenuItem();
        searchToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator5 = new ToolStripSeparator();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        insertObejctToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
        splitContainer2.Panel1.SuspendLayout();
        splitContainer2.Panel2.SuspendLayout();
        splitContainer2.SuspendLayout();
        tabControl1.SuspendLayout();
        tab_Dev.SuspendLayout();
        tab_Upgrade.SuspendLayout();
        groupBox1.SuspendLayout();
        tabControl2.SuspendLayout();
        SuspendLayout();
        // 
        // statusStrip1
        // 
        statusStrip1.Location = new Point(0, 539);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(784, 22);
        statusStrip1.TabIndex = 0;
        statusStrip1.Text = "statusStrip1";
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, editToolStripMenuItem1, viewToolStripMenuItem, insertToolStripMenuItem, buildToolStripMenuItem, debugToolStripMenuItem, toolsToolStripMenuItem1, goToolStripMenuItem, windowToolStripMenuItem, helpToolStripMenuItem1 });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(784, 24);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Size = new Size(44, 20);
        viewToolStripMenuItem.Text = "View";
        // 
        // insertToolStripMenuItem
        // 
        insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertObejctToolStripMenuItem });
        insertToolStripMenuItem.Name = "insertToolStripMenuItem";
        insertToolStripMenuItem.Size = new Size(48, 20);
        insertToolStripMenuItem.Text = "Insert";
        // 
        // buildToolStripMenuItem
        // 
        buildToolStripMenuItem.Name = "buildToolStripMenuItem";
        buildToolStripMenuItem.Size = new Size(46, 20);
        buildToolStripMenuItem.Text = "Build";
        // 
        // debugToolStripMenuItem
        // 
        debugToolStripMenuItem.Name = "debugToolStripMenuItem";
        debugToolStripMenuItem.Size = new Size(54, 20);
        debugToolStripMenuItem.Text = "Debug";
        // 
        // goToolStripMenuItem
        // 
        goToolStripMenuItem.Name = "goToolStripMenuItem";
        goToolStripMenuItem.Size = new Size(34, 20);
        goToolStripMenuItem.Text = "Go";
        // 
        // windowToolStripMenuItem
        // 
        windowToolStripMenuItem.Name = "windowToolStripMenuItem";
        windowToolStripMenuItem.Size = new Size(63, 20);
        windowToolStripMenuItem.Text = "Window";
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 24);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(splitContainer2);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(tabControl2);
        splitContainer1.Size = new Size(784, 515);
        splitContainer1.SplitterDistance = 339;
        splitContainer1.TabIndex = 2;
        // 
        // splitContainer2
        // 
        splitContainer2.Dock = DockStyle.Fill;
        splitContainer2.Location = new Point(0, 0);
        splitContainer2.Name = "splitContainer2";
        // 
        // splitContainer2.Panel1
        // 
        splitContainer2.Panel1.Controls.Add(tabControl1);
        // 
        // splitContainer2.Panel2
        // 
        splitContainer2.Panel2.Controls.Add(groupBox1);
        splitContainer2.Size = new Size(784, 339);
        splitContainer2.SplitterDistance = 261;
        splitContainer2.TabIndex = 0;
        // 
        // tabControl1
        // 
        tabControl1.Alignment = TabAlignment.Bottom;
        tabControl1.Controls.Add(tab_Dev);
        tabControl1.Controls.Add(tab_Upgrade);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(261, 339);
        tabControl1.TabIndex = 0;
        // 
        // tab_Dev
        // 
        tab_Dev.Controls.Add(DevelopmentTreeView);
        tab_Dev.Location = new Point(4, 4);
        tab_Dev.Name = "tab_Dev";
        tab_Dev.Padding = new Padding(3);
        tab_Dev.Size = new Size(253, 311);
        tab_Dev.TabIndex = 0;
        tab_Dev.Text = "Development";
        // 
        // DevelopmentTreeView
        // 
        DevelopmentTreeView.Dock = DockStyle.Fill;
        DevelopmentTreeView.Location = new Point(3, 3);
        DevelopmentTreeView.Name = "DevelopmentTreeView";
        DevelopmentTreeView.Size = new Size(247, 305);
        DevelopmentTreeView.TabIndex = 0;
        // 
        // tab_Upgrade
        // 
        tab_Upgrade.Controls.Add(UpgradeTreeView);
        tab_Upgrade.Location = new Point(4, 4);
        tab_Upgrade.Name = "tab_Upgrade";
        tab_Upgrade.Padding = new Padding(3);
        tab_Upgrade.Size = new Size(253, 311);
        tab_Upgrade.TabIndex = 1;
        tab_Upgrade.Text = "Upgrade";
        tab_Upgrade.UseVisualStyleBackColor = true;
        // 
        // UpgradeTreeView
        // 
        UpgradeTreeView.Dock = DockStyle.Fill;
        UpgradeTreeView.Location = new Point(3, 3);
        UpgradeTreeView.Name = "UpgradeTreeView";
        UpgradeTreeView.Size = new Size(247, 305);
        UpgradeTreeView.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(openFilesTC);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(519, 339);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Open Objects";
        // 
        // openFilesTC
        // 
        openFilesTC.Dock = DockStyle.Fill;
        openFilesTC.Location = new Point(3, 19);
        openFilesTC.Name = "openFilesTC";
        openFilesTC.SelectedIndex = 0;
        openFilesTC.Size = new Size(513, 317);
        openFilesTC.TabIndex = 0;
        // 
        // tabControl2
        // 
        tabControl2.Alignment = TabAlignment.Bottom;
        tabControl2.Controls.Add(tabPage3);
        tabControl2.Controls.Add(tabPage4);
        tabControl2.Controls.Add(tabPage5);
        tabControl2.Controls.Add(tabPage6);
        tabControl2.Dock = DockStyle.Fill;
        tabControl2.Location = new Point(0, 0);
        tabControl2.Name = "tabControl2";
        tabControl2.SelectedIndex = 0;
        tabControl2.Size = new Size(784, 172);
        tabControl2.TabIndex = 0;
        // 
        // tabPage3
        // 
        tabPage3.Location = new Point(4, 4);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(776, 144);
        tabPage3.TabIndex = 0;
        tabPage3.Text = "Build";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // tabPage4
        // 
        tabPage4.Location = new Point(4, 4);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3);
        tabPage4.Size = new Size(776, 144);
        tabPage4.TabIndex = 1;
        tabPage4.Text = "Upgrade";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // tabPage5
        // 
        tabPage5.Location = new Point(4, 4);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3);
        tabPage5.Size = new Size(776, 144);
        tabPage5.TabIndex = 2;
        tabPage5.Text = "Results";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // tabPage6
        // 
        tabPage6.Location = new Point(4, 4);
        tabPage6.Name = "tabPage6";
        tabPage6.Padding = new Padding(3);
        tabPage6.Size = new Size(776, 144);
        tabPage6.TabIndex = 3;
        tabPage6.Text = "Validate";
        tabPage6.UseVisualStyleBackColor = true;
        // 
        // fileToolStripMenuItem1
        // 
        fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
        fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
        fileToolStripMenuItem1.Size = new Size(37, 20);
        fileToolStripMenuItem1.Text = "&File";
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
        newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        newToolStripMenuItem.Size = new Size(180, 22);
        newToolStripMenuItem.Text = "&New";
        newToolStripMenuItem.Click += newToolStripMenuItem_Click;
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
        openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        openToolStripMenuItem.Size = new Size(180, 22);
        openToolStripMenuItem.Text = "&Open";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new Size(177, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
        saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        saveToolStripMenuItem.Size = new Size(180, 22);
        saveToolStripMenuItem.Text = "&Save";
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Size = new Size(180, 22);
        saveAsToolStripMenuItem.Text = "Save &As";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(177, 6);
        // 
        // printToolStripMenuItem
        // 
        printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
        printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        printToolStripMenuItem.Name = "printToolStripMenuItem";
        printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
        printToolStripMenuItem.Size = new Size(180, 22);
        printToolStripMenuItem.Text = "&Print";
        // 
        // printPreviewToolStripMenuItem
        // 
        printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
        printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
        printPreviewToolStripMenuItem.Size = new Size(180, 22);
        printPreviewToolStripMenuItem.Text = "Print Pre&view";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(177, 6);
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(180, 22);
        exitToolStripMenuItem.Text = "E&xit";
        // 
        // editToolStripMenuItem1
        // 
        editToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
        editToolStripMenuItem1.Name = "editToolStripMenuItem1";
        editToolStripMenuItem1.Size = new Size(39, 20);
        editToolStripMenuItem1.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
        undoToolStripMenuItem.Size = new Size(180, 22);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
        redoToolStripMenuItem.Size = new Size(180, 22);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(177, 6);
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
        cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        cutToolStripMenuItem.Size = new Size(180, 22);
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
        copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
        copyToolStripMenuItem.Size = new Size(180, 22);
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
        pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
        pasteToolStripMenuItem.Size = new Size(180, 22);
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(177, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.Size = new Size(180, 22);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // toolsToolStripMenuItem1
        // 
        toolsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
        toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
        toolsToolStripMenuItem1.Size = new Size(46, 20);
        toolsToolStripMenuItem1.Text = "&Tools";
        // 
        // customizeToolStripMenuItem
        // 
        customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
        customizeToolStripMenuItem.Size = new Size(180, 22);
        customizeToolStripMenuItem.Text = "&Customize";
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new Size(180, 22);
        optionsToolStripMenuItem.Text = "&Options";
        // 
        // helpToolStripMenuItem1
        // 
        helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
        helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
        helpToolStripMenuItem1.Size = new Size(44, 20);
        helpToolStripMenuItem1.Text = "&Help";
        // 
        // contentsToolStripMenuItem
        // 
        contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
        contentsToolStripMenuItem.Size = new Size(180, 22);
        contentsToolStripMenuItem.Text = "&Contents";
        // 
        // indexToolStripMenuItem
        // 
        indexToolStripMenuItem.Name = "indexToolStripMenuItem";
        indexToolStripMenuItem.Size = new Size(180, 22);
        indexToolStripMenuItem.Text = "&Index";
        // 
        // searchToolStripMenuItem
        // 
        searchToolStripMenuItem.Name = "searchToolStripMenuItem";
        searchToolStripMenuItem.Size = new Size(180, 22);
        searchToolStripMenuItem.Text = "&Search";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(177, 6);
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(180, 22);
        aboutToolStripMenuItem.Text = "&About...";
        // 
        // insertObejctToolStripMenuItem
        // 
        insertObejctToolStripMenuItem.Name = "insertObejctToolStripMenuItem";
        insertObejctToolStripMenuItem.Size = new Size(205, 22);
        insertObejctToolStripMenuItem.Text = "Insert Obejct into Project";
        // 
        // AppDesigner
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 561);
        Controls.Add(splitContainer1);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "AppDesigner";
        Text = "Application Designer";
        Load += populateGo;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        splitContainer2.Panel1.ResumeLayout(false);
        splitContainer2.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
        splitContainer2.ResumeLayout(false);
        tabControl1.ResumeLayout(false);
        tab_Dev.ResumeLayout(false);
        tab_Upgrade.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        tabControl2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private StatusStrip statusStrip1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem insertToolStripMenuItem;
    private ToolStripMenuItem buildToolStripMenuItem;
    private ToolStripMenuItem debugToolStripMenuItem;
    private ToolStripMenuItem goToolStripMenuItem;
    private ToolStripMenuItem windowToolStripMenuItem;
    private SplitContainer splitContainer1;
    private SplitContainer splitContainer2;
    private TabControl tabControl1;
    private TabPage tab_Dev;
    private TabPage tab_Upgrade;
    private TabControl tabControl2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private TabPage tabPage6;
    private TreeView UpgradeTreeView;
    private TreeView DevelopmentTreeView;
    private GroupBox groupBox1;
    private TabControl openFilesTC;
    private ToolStripMenuItem fileToolStripMenuItem1;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem printToolStripMenuItem;
    private ToolStripMenuItem printPreviewToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem1;
    private ToolStripMenuItem undoToolStripMenuItem;
    private ToolStripMenuItem redoToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem cutToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem pasteToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem selectAllToolStripMenuItem;
    private ToolStripMenuItem toolsToolStripMenuItem1;
    private ToolStripMenuItem customizeToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem1;
    private ToolStripMenuItem contentsToolStripMenuItem;
    private ToolStripMenuItem indexToolStripMenuItem;
    private ToolStripMenuItem searchToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem insertObejctToolStripMenuItem;
}
