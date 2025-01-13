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
        statusStrip1 = new StatusStrip();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        viewToolStripMenuItem = new ToolStripMenuItem();
        insertToolStripMenuItem = new ToolStripMenuItem();
        buildToolStripMenuItem = new ToolStripMenuItem();
        debugToolStripMenuItem = new ToolStripMenuItem();
        toolsToolStripMenuItem = new ToolStripMenuItem();
        goToolStripMenuItem = new ToolStripMenuItem();
        windowToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        testToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // statusStrip1
        // 
        statusStrip1.Location = new Point(0, 428);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(800, 22);
        statusStrip1.TabIndex = 0;
        statusStrip1.Text = "statusStrip1";
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, insertToolStripMenuItem, buildToolStripMenuItem, debugToolStripMenuItem, toolsToolStripMenuItem, goToolStripMenuItem, windowToolStripMenuItem, helpToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 24);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "File";
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(39, 20);
        editToolStripMenuItem.Text = "Edit";
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Size = new Size(44, 20);
        viewToolStripMenuItem.Text = "View";
        // 
        // insertToolStripMenuItem
        // 
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
        // toolsToolStripMenuItem
        // 
        toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
        toolsToolStripMenuItem.Size = new Size(46, 20);
        toolsToolStripMenuItem.Text = "Tools";
        // 
        // goToolStripMenuItem
        // 
        goToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testToolStripMenuItem });
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
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(44, 20);
        helpToolStripMenuItem.Text = "Help";
        // 
        // testToolStripMenuItem
        // 
        testToolStripMenuItem.Name = "testToolStripMenuItem";
        testToolStripMenuItem.Size = new Size(180, 22);
        testToolStripMenuItem.Text = "Test";
        // 
        // AppDesigner
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "AppDesigner";
        Text = "Application Designer";
        Load += populateGo;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private StatusStrip statusStrip1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem insertToolStripMenuItem;
    private ToolStripMenuItem buildToolStripMenuItem;
    private ToolStripMenuItem debugToolStripMenuItem;
    private ToolStripMenuItem toolsToolStripMenuItem;
    private ToolStripMenuItem goToolStripMenuItem;
    private ToolStripMenuItem windowToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem testToolStripMenuItem;
}
