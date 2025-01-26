namespace Test
{
    partial class Main
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
            AIMS.Libraries.CodeEditor.WinForms.LineMarginRender lineMarginRender2 = new AIMS.Libraries.CodeEditor.WinForms.LineMarginRender();
            this.syntaxDocument1 = new AIMS.Libraries.CodeEditor.Syntax.SyntaxDocument(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.codeEditorControl1 = new AIMS.Libraries.CodeEditor.CodeEditorControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // syntaxDocument1
            // 
            this.syntaxDocument1.Lines = new string[] {
        ""};
            this.syntaxDocument1.MaxUndoBufferSize = 1000;
            this.syntaxDocument1.Modified = false;
            this.syntaxDocument1.UndoStep = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.codeEditorControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 393);
            this.panel1.TabIndex = 0;
            // 
            // codeEditorControl1
            // 
            this.codeEditorControl1.ActiveView = AIMS.Libraries.CodeEditor.WinForms.ActiveView.BottomRight;
            this.codeEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.codeEditorControl1.AutoListPosition = null;
            this.codeEditorControl1.AutoListSelectedText = "a123";
            this.codeEditorControl1.AutoListVisible = false;
            this.codeEditorControl1.CopyAsRTF = false;
            this.codeEditorControl1.Document = this.syntaxDocument1;
            this.codeEditorControl1.InfoTipCount = 1;
            this.codeEditorControl1.InfoTipPosition = null;
            this.codeEditorControl1.InfoTipSelectedIndex = 1;
            this.codeEditorControl1.InfoTipVisible = false;
            lineMarginRender2.Bounds = new System.Drawing.Rectangle(19, 0, 19, 16);
            this.codeEditorControl1.LineMarginRender = lineMarginRender2;
            this.codeEditorControl1.Location = new System.Drawing.Point(3, 35);
            this.codeEditorControl1.LockCursorUpdate = false;
            this.codeEditorControl1.Name = "codeEditorControl1";
            this.codeEditorControl1.Saved = false;
            this.codeEditorControl1.ShowScopeIndicator = false;
            this.codeEditorControl1.Size = new System.Drawing.Size(454, 311);
            this.codeEditorControl1.SmoothScroll = false;
            this.codeEditorControl1.SplitviewH = -4;
            this.codeEditorControl1.SplitviewV = -4;
            this.codeEditorControl1.TabGuideColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.codeEditorControl1.TabIndex = 1;
            this.codeEditorControl1.Text = "codeEditorControl1";
            this.codeEditorControl1.WhitespaceColor = System.Drawing.SystemColors.ControlDark;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 26);
            this.panel2.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 26);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(614, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 393);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AIMS.Libraries.CodeEditor.Syntax.SyntaxDocument syntaxDocument1;
        private System.Windows.Forms.Panel panel1;
        private AIMS.Libraries.CodeEditor.CodeEditorControl codeEditorControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

