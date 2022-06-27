using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

        public class Section
        {
            public string sectionName;
            public string sectionTime;
        }

        public class PracticeRecord
        {
            public DateTime recordDate;
            public DateTime recordStartTime;
            public DateTime recordEndTime;
            public List<Section> sectionData;
        }

        public PracticeRecord Student = new PracticeRecord();
        public int stH;
        public int stM;
        public int etH;
        public int etM;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Student.sectionData = new List<Section>();
            stH = Convert.ToInt32(startTimeH.Text);
            stM = Convert.ToInt32(startTimeM.Text);
            etH = Convert.ToInt32(endTimeH.Text);
            etM = Convert.ToInt32(endTimeM.Text);
            Student.recordDate = recordDatePicker.Value;
            Student.recordStartTime = Student.recordStartTime.Date.AddHours(stH).AddMinutes(stM);
            Student.recordEndTime = Student.recordEndTime.Date.AddHours(etH).AddMinutes(etM);

            for(int i = 0; i < listView.Items.Count; i++)
            {
               Section sectionData = new Section();
               sectionData.sectionName = listView.Items[i].SubItems[0].Text;
               sectionData.sectionTime = listView.Items[i].SubItems[1].Text;
               Student.sectionData.Add(sectionData);
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create("data.xml", settings))
            {
                writer.WriteStartElement("pRecordData");
                writer.WriteStartElement("practiceRecord");
                writer.WriteElementString("date", Student.recordDate.ToString("dd/MM/yyyy"));
                writer.WriteElementString("startTime", Student.recordStartTime.ToString("H:m"));
                writer.WriteElementString("endTime", Student.recordEndTime.ToString("H:m"));
                writer.WriteStartElement("sectionData");
                foreach(Section sectionData in Student.sectionData)
                {
                    writer.WriteStartElement("section");
                    writer.WriteElementString("name", sectionData.sectionName);
                    writer.WriteElementString("time", sectionData.sectionTime);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Flush();
            }

            this.Close();
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
