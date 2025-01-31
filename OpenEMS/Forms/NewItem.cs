using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenEMS.Enums;

namespace OpenEMS.Forms
{
    public partial class NewItem : Form
    {
        public FileType FileType;
        public string fileName { get => txt_itemName.Text; }
        public NewItem()
        {
            InitializeComponent();
        }

        private void NewItem_Load(object sender, EventArgs e)
        {
            listView1.LargeImageList = imageList1;
            listView1.Items.Add("SQL Table", 0);
            listView1.Items.Add("SQL Column", 0);
            listView1.Items.Add("C# Plugin", 1);
            listView1.Items.Add("C# File", 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            switch (listView1.SelectedItems[0].Text)
            {
                case "SQL Table":
                    this.FileType = FileType.SqlTbl;
                    break;
                case "SQL Column":
                    this.FileType = FileType.SqlCol;
                    break;
                case "C# Plugin":
                    this.FileType = FileType.CsProj;
                    break;
                case "C# File":
                    this.FileType = FileType.CsFile;
                    break;
            }
            this.Close();
        }
    }
}
