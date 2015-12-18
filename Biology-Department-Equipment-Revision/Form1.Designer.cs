namespace Biology_Department_Equipment_Revision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.ComboBox();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.yearGroup = new System.Windows.Forms.ComboBox();
            this.groups = new System.Windows.Forms.ComboBox();
            this.period = new System.Windows.Forms.ComboBox();
            this.equipment = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hazcards = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biology Department Equipment Revision";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // teacher
            // 
            this.teacher.FormattingEnabled = true;
            this.teacher.Items.AddRange(new object[] {
            "Dr. Gilbert [ALG]",
            "Dr. Pett [MRP]",
            "Mr. Smith [MS]",
            "Mrs. Allison [CGA]",
            "Mrs. Baxter [AMB]",
            "Mrs. Brown [LVB]",
            "Mrs. Jagger [CHJ]",
            "Mrs. Walker [BAW]",
            "Mrs. Yuasa [AY]"});
            this.teacher.Location = new System.Drawing.Point(27, 62);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(121, 21);
            this.teacher.TabIndex = 1;
            this.teacher.Text = "Select a Teacher.";
            this.teacher.SelectedIndexChanged += new System.EventHandler(this.teacher_SelectedIndexChanged);
            // 
            // calendar
            // 
            this.calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.CustomFormat = "dd/MM";
            this.calendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calendar.Location = new System.Drawing.Point(188, 63);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(109, 20);
            this.calendar.TabIndex = 2;
            this.calendar.Value = new System.DateTime(2015, 12, 18, 0, 0, 0, 0);
            // 
            // time
            // 
            this.time.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(303, 62);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(112, 20);
            this.time.TabIndex = 3;
            // 
            // yearGroup
            // 
            this.yearGroup.FormattingEnabled = true;
            this.yearGroup.Items.AddRange(new object[] {
            "Year 7",
            "Year 8",
            "Year 9",
            "Year 10",
            "Year 11",
            "Year 12",
            "Year 13"});
            this.yearGroup.Location = new System.Drawing.Point(447, 62);
            this.yearGroup.Name = "yearGroup";
            this.yearGroup.Size = new System.Drawing.Size(121, 21);
            this.yearGroup.TabIndex = 4;
            this.yearGroup.Text = "Select a Year Group.";
            // 
            // groups
            // 
            this.groups.FormattingEnabled = true;
            this.groups.Items.AddRange(new object[] {
            "1 Group",
            "2 Groups",
            "3 Groups",
            "4 Groups",
            "5 Groups",
            "6 Groups",
            "7 Groups",
            "8 Groups"});
            this.groups.Location = new System.Drawing.Point(27, 100);
            this.groups.Name = "groups";
            this.groups.Size = new System.Drawing.Size(121, 21);
            this.groups.TabIndex = 5;
            this.groups.Text = "How many groups?";
            this.groups.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // period
            // 
            this.period.FormattingEnabled = true;
            this.period.Items.AddRange(new object[] {
            "Period 1",
            "Period 2",
            "Period 3",
            "Period 4",
            "Period 5",
            "Period 6"});
            this.period.Location = new System.Drawing.Point(447, 100);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(121, 21);
            this.period.TabIndex = 6;
            this.period.Text = "Select a Period.";
            this.period.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // equipment
            // 
            this.equipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment.Location = new System.Drawing.Point(188, 101);
            this.equipment.Multiline = true;
            this.equipment.Name = "equipment";
            this.equipment.Size = new System.Drawing.Size(227, 152);
            this.equipment.TabIndex = 7;
            this.equipment.Text = "Enter Equipment here....";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Biology_Department_Equipment_Revision.Properties.Resources.tree;
            this.pictureBox2.Location = new System.Drawing.Point(447, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 126);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biology_Department_Equipment_Revision.Properties.Resources.microscope_inBox;
            this.pictureBox1.Location = new System.Drawing.Point(27, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 126);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // hazcards
            // 
            this.hazcards.Location = new System.Drawing.Point(27, 268);
            this.hazcards.Name = "hazcards";
            this.hazcards.Size = new System.Drawing.Size(388, 20);
            this.hazcards.TabIndex = 10;
            this.hazcards.Text = "Enter Hazcards here....";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PaleGreen;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(447, 259);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 36);
            this.submit.TabIndex = 11;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(600, 306);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.hazcards);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.equipment);
            this.Controls.Add(this.period);
            this.Controls.Add(this.groups);
            this.Controls.Add(this.yearGroup);
            this.Controls.Add(this.time);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Biology Department Equipment Revision";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.ComboBox yearGroup;
        private System.Windows.Forms.ComboBox groups;
        private System.Windows.Forms.ComboBox period;
        private System.Windows.Forms.TextBox equipment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox hazcards;
        private System.Windows.Forms.Button submit;
    }
}

