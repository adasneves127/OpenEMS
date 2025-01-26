using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AIMS.Libraries.CodeEditor.SyntaxFiles;
using AIMS.Libraries.CodeEditor.Syntax;
namespace Test
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            codeEditorControl1.SplitView = false;
            LanguageList list  = CodeEditorSyntaxLoader.LanguageList;
            IEnumerator listEnum = list.ListLanguages();
            CodeEditorSyntaxLoader.SetSyntax(codeEditorControl1, SyntaxLanguage.HTML);
            while (listEnum.MoveNext())
            {
                
                comboBox1.Items.Add(listEnum.Current.ToString());
                
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CodeEditorSyntaxLoader.SetSyntax(codeEditorControl1,SyntaxLanguage.CSharp);
        }
    }
}