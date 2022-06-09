
namespace Music_Practice_Recording_App
{
    partial class Form2
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
            this.recordDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.startTimeH = new System.Windows.Forms.TextBox();
            this.startTimeM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endTimeM = new System.Windows.Forms.TextBox();
            this.endTimeH = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSetTime1 = new System.Windows.Forms.Button();
            this.btnSetTime2 = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // recordDatePicker
            // 
            this.recordDatePicker.AllowDrop = true;
            this.recordDatePicker.Location = new System.Drawing.Point(89, 21);
            this.recordDatePicker.Name = "recordDatePicker";
            this.recordDatePicker.Size = new System.Drawing.Size(200, 20);
            this.recordDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // startTimeH
            // 
            this.startTimeH.Location = new System.Drawing.Point(105, 60);
            this.startTimeH.Name = "startTimeH";
            this.startTimeH.Size = new System.Drawing.Size(48, 20);
            this.startTimeH.TabIndex = 2;
            // 
            // startTimeM
            // 
            this.startTimeM.Location = new System.Drawing.Point(159, 60);
            this.startTimeM.Name = "startTimeM";
            this.startTimeM.Size = new System.Drawing.Size(48, 20);
            this.startTimeM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "End Time";
            // 
            // endTimeM
            // 
            this.endTimeM.Location = new System.Drawing.Point(159, 101);
            this.endTimeM.Name = "endTimeM";
            this.endTimeM.Size = new System.Drawing.Size(48, 20);
            this.endTimeM.TabIndex = 6;
            // 
            // endTimeH
            // 
            this.endTimeH.Location = new System.Drawing.Point(105, 101);
            this.endTimeH.Name = "endTimeH";
            this.endTimeH.Size = new System.Drawing.Size(48, 20);
            this.endTimeH.TabIndex = 5;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(353, 233);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 34);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sections";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(105, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(136, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "-";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSetTime1
            // 
            this.btnSetTime1.Location = new System.Drawing.Point(226, 58);
            this.btnSetTime1.Name = "btnSetTime1";
            this.btnSetTime1.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime1.TabIndex = 14;
            this.btnSetTime1.Text = "Set Time";
            this.btnSetTime1.UseVisualStyleBackColor = true;
            this.btnSetTime1.Click += new System.EventHandler(this.btnSetTime1_Click);
            // 
            // btnSetTime2
            // 
            this.btnSetTime2.Location = new System.Drawing.Point(226, 99);
            this.btnSetTime2.Name = "btnSetTime2";
            this.btnSetTime2.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime2.TabIndex = 15;
            this.btnSetTime2.Text = "Set Time";
            this.btnSetTime2.UseVisualStyleBackColor = true;
            this.btnSetTime2.Click += new System.EventHandler(this.btnSetTime2_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnTime});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(33, 167);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(216, 100);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // clmnName
            // 
            this.clmnName.Text = "Name";
            this.clmnName.Width = 177;
            // 
            // clmnTime
            // 
            this.clmnTime.Text = "Time";
            this.clmnTime.Width = 35;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 287);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnSetTime2);
            this.Controls.Add(this.btnSetTime1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endTimeM);
            this.Controls.Add(this.endTimeH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTimeM);
            this.Controls.Add(this.startTimeH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordDatePicker);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker recordDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startTimeH;
        private System.Windows.Forms.TextBox startTimeM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endTimeM;
        private System.Windows.Forms.TextBox endTimeH;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSetTime1;
        private System.Windows.Forms.Button btnSetTime2;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnTime;
        public System.Windows.Forms.ListView listView;
    }
}