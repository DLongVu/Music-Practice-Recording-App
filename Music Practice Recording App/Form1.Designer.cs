
namespace Music_Practice_Recording_App
{
    partial class Form1
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
            this.CreateRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateRecord
            // 
            this.CreateRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateRecord.Location = new System.Drawing.Point(332, 52);
            this.CreateRecord.Name = "CreateRecord";
            this.CreateRecord.Size = new System.Drawing.Size(170, 47);
            this.CreateRecord.TabIndex = 0;
            this.CreateRecord.Text = "Create Record";
            this.CreateRecord.UseVisualStyleBackColor = true;
            this.CreateRecord.Click += new System.EventHandler(this.CreateRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.CreateRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateRecord;
    }
}

