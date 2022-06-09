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
    public partial class Form1 : Form
    {
        public class Section
        {
            public string sectionName;
            public TimeSpan sectionTime;
        }

        public class Record
        {
            public string recordID;
            public DateTime recordDate;
            public DateTime recordStartTime;
            public DateTime recordEndTime;
            public List<Section> sectionData;
        }

        public Record Student;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void CreateRecord_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
