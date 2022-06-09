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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            startTimeH.Text = Convert.ToString(dt.Hour);
            startTimeM.Text = Convert.ToString(dt.Minute);
        }

        public Form1.Record Student = new Form1.Record();
        public int stH;
        public int stM;
        public int etH;
        public int etM;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            stH = Convert.ToInt32(startTimeH.Text);
            stM = Convert.ToInt32(startTimeM.Text);
            etH = Convert.ToInt32(endTimeH.Text);
            etM = Convert.ToInt32(endTimeM.Text);
            Student.recordDate = recordDatePicker.Value;
            Student.recordStartTime = Student.recordStartTime.Date.AddHours(stH).AddMinutes(stM);
            Student.recordEndTime = Student.recordEndTime.Date.AddHours(etH).AddMinutes(etM);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        private void btnSetTime1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            startTimeH.Text = Convert.ToString(dt.Hour);
            startTimeM.Text = Convert.ToString(dt.Minute);
        }

        private void btnSetTime2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            endTimeH.Text = Convert.ToString(dt.Hour);
            endTimeM.Text = Convert.ToString(dt.Minute);
        }
    }
}
