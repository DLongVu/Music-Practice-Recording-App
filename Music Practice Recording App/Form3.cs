using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Practice_Recording_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static string name;
        Form2 f2 = Form2.ActiveForm as Form2;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtBxName != null)
            {
                name = txtBxName.Text;
            }

            if(string.IsNullOrEmpty(txtBxName.Text) || string.IsNullOrEmpty(txtBxTime.Text))
            {
                return;
            }
            ListViewItem item = new ListViewItem(txtBxName.Text);
            item.SubItems.Add(txtBxTime.Text);
            f2.listView.Items.Add(item);
            this.Close();
        }
    }
}
