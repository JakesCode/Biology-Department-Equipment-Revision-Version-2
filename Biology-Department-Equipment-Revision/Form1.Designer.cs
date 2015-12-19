﻿namespace BDER
{
    partial class appWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.ComboBox();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.yearGroup = new System.Windows.Forms.ComboBox();
            this.groups = new System.Windows.Forms.ComboBox();
            this.period = new System.Windows.Forms.ComboBox();
            this.equipment = new System.Windows.Forms.TextBox();
            this.hazcards = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.riskAssessment = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // teacher
            // 
            this.teacher.FormattingEnabled = true;
            this.teacher.Items.AddRange(new object[] {
            resources.GetString("teacher.Items"),
            resources.GetString("teacher.Items1"),
            resources.GetString("teacher.Items2"),
            resources.GetString("teacher.Items3"),
            resources.GetString("teacher.Items4"),
            resources.GetString("teacher.Items5"),
            resources.GetString("teacher.Items6"),
            resources.GetString("teacher.Items7"),
            resources.GetString("teacher.Items8")});
            resources.ApplyResources(this.teacher, "teacher");
            this.teacher.Name = "teacher";
            this.teacher.SelectedIndexChanged += new System.EventHandler(this.teacher_SelectedIndexChanged);
            // 
            // calendar
            // 
            resources.ApplyResources(this.calendar, "calendar");
            this.calendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calendar.Name = "calendar";
            this.calendar.Value = new System.DateTime(2015, 12, 18, 0, 0, 0, 0);
            this.calendar.ValueChanged += new System.EventHandler(this.calendar_ValueChanged);
            // 
            // yearGroup
            // 
            this.yearGroup.FormattingEnabled = true;
            this.yearGroup.Items.AddRange(new object[] {
            resources.GetString("yearGroup.Items"),
            resources.GetString("yearGroup.Items1"),
            resources.GetString("yearGroup.Items2"),
            resources.GetString("yearGroup.Items3"),
            resources.GetString("yearGroup.Items4"),
            resources.GetString("yearGroup.Items5"),
            resources.GetString("yearGroup.Items6")});
            resources.ApplyResources(this.yearGroup, "yearGroup");
            this.yearGroup.Name = "yearGroup";
            // 
            // groups
            // 
            this.groups.FormattingEnabled = true;
            this.groups.Items.AddRange(new object[] {
            resources.GetString("groups.Items"),
            resources.GetString("groups.Items1"),
            resources.GetString("groups.Items2"),
            resources.GetString("groups.Items3"),
            resources.GetString("groups.Items4"),
            resources.GetString("groups.Items5"),
            resources.GetString("groups.Items6"),
            resources.GetString("groups.Items7")});
            resources.ApplyResources(this.groups, "groups");
            this.groups.Name = "groups";
            this.groups.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // period
            // 
            this.period.FormattingEnabled = true;
            this.period.Items.AddRange(new object[] {
            resources.GetString("period.Items"),
            resources.GetString("period.Items1"),
            resources.GetString("period.Items2"),
            resources.GetString("period.Items3"),
            resources.GetString("period.Items4"),
            resources.GetString("period.Items5")});
            resources.ApplyResources(this.period, "period");
            this.period.Name = "period";
            this.period.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // equipment
            // 
            resources.ApplyResources(this.equipment, "equipment");
            this.equipment.Name = "equipment";
            // 
            // hazcards
            // 
            resources.ApplyResources(this.hazcards, "hazcards");
            this.hazcards.Name = "hazcards";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PaleGreen;
            resources.ApplyResources(this.submit, "submit");
            this.submit.Name = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // riskAssessment
            // 
            resources.ApplyResources(this.riskAssessment, "riskAssessment");
            this.riskAssessment.Name = "riskAssessment";
            this.riskAssessment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BDER.Properties.Resources.tree;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BDER.Properties.Resources.microscope_inBox;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.PaleGreen;
            resources.ApplyResources(this.load, "load");
            this.load.Name = "load";
            this.load.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.PaleGreen;
            resources.ApplyResources(this.save, "save");
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // appWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.riskAssessment);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.hazcards);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.equipment);
            this.Controls.Add(this.period);
            this.Controls.Add(this.groups);
            this.Controls.Add(this.yearGroup);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "appWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.ComboBox yearGroup;
        private System.Windows.Forms.ComboBox groups;
        private System.Windows.Forms.ComboBox period;
        private System.Windows.Forms.TextBox equipment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox hazcards;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox riskAssessment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
    }
}

