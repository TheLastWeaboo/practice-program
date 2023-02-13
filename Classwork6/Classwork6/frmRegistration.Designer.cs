namespace Classwork6
{
    partial class frmRegistration
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
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.rbtn4th = new System.Windows.Forms.RadioButton();
            this.rbtn3rd = new System.Windows.Forms.RadioButton();
            this.rbtn2nd = new System.Windows.Forms.RadioButton();
            this.rbtn1st = new System.Windows.Forms.RadioButton();
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxMiddleInitial = new System.Windows.Forms.TextBox();
            this.gbxSection = new System.Windows.Forms.GroupBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lsbSection = new System.Windows.Forms.ListBox();
            this.gbxYearlevel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCourse.SuspendLayout();
            this.gbxSection.SuspendLayout();
            this.gbxYearlevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFirstName.Location = new System.Drawing.Point(172, 82);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbxFirstName.TabIndex = 3;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleInitial.Location = new System.Drawing.Point(351, 107);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(117, 14);
            this.lblMiddleInitial.TabIndex = 2;
            this.lblMiddleInitial.Text = "MIDDLE INITIAL";
            this.lblMiddleInitial.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(37, 107);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 14);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "FAMILY NAME";
            this.lblLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(200, 107);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 14);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FIRST NAME";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtn4th
            // 
            this.rbtn4th.AutoSize = true;
            this.rbtn4th.Location = new System.Drawing.Point(365, 21);
            this.rbtn4th.Name = "rbtn4th";
            this.rbtn4th.Size = new System.Drawing.Size(83, 18);
            this.rbtn4th.TabIndex = 5;
            this.rbtn4th.TabStop = true;
            this.rbtn4th.Text = "4th Year";
            this.rbtn4th.UseVisualStyleBackColor = true;
            this.rbtn4th.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbtn3rd
            // 
            this.rbtn3rd.AutoSize = true;
            this.rbtn3rd.Location = new System.Drawing.Point(253, 21);
            this.rbtn3rd.Name = "rbtn3rd";
            this.rbtn3rd.Size = new System.Drawing.Size(84, 18);
            this.rbtn3rd.TabIndex = 4;
            this.rbtn3rd.TabStop = true;
            this.rbtn3rd.Text = "3rd Year";
            this.rbtn3rd.UseVisualStyleBackColor = true;
            // 
            // rbtn2nd
            // 
            this.rbtn2nd.AutoSize = true;
            this.rbtn2nd.Location = new System.Drawing.Point(144, 21);
            this.rbtn2nd.Name = "rbtn2nd";
            this.rbtn2nd.Size = new System.Drawing.Size(86, 18);
            this.rbtn2nd.TabIndex = 3;
            this.rbtn2nd.TabStop = true;
            this.rbtn2nd.Text = "2nd Year";
            this.rbtn2nd.UseVisualStyleBackColor = true;
            this.rbtn2nd.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtn1st
            // 
            this.rbtn1st.AutoSize = true;
            this.rbtn1st.BackColor = System.Drawing.Color.Transparent;
            this.rbtn1st.Location = new System.Drawing.Point(32, 21);
            this.rbtn1st.Name = "rbtn1st";
            this.rbtn1st.Size = new System.Drawing.Size(71, 18);
            this.rbtn1st.TabIndex = 2;
            this.rbtn1st.TabStop = true;
            this.rbtn1st.Text = "Europe";
            this.rbtn1st.UseVisualStyleBackColor = false;
            // 
            // gbxCourse
            // 
            this.gbxCourse.BackColor = System.Drawing.Color.Transparent;
            this.gbxCourse.Controls.Add(this.cbxCourse);
            this.gbxCourse.Location = new System.Drawing.Point(12, 294);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(147, 52);
            this.gbxCourse.TabIndex = 2;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "Course";
            // 
            // cbxCourse
            // 
            this.cbxCourse.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "BSHM",
            "BSED"});
            this.cbxCourse.Location = new System.Drawing.Point(7, 21);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(138, 22);
            this.cbxCourse.TabIndex = 0;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStudentName.Location = new System.Drawing.Point(158, 22);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(182, 23);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Character name";
            this.lblStudentName.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxLastName.Location = new System.Drawing.Point(12, 82);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(145, 22);
            this.tbxLastName.TabIndex = 7;
            this.tbxLastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxMiddleInitial
            // 
            this.tbxMiddleInitial.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMiddleInitial.Location = new System.Drawing.Point(334, 82);
            this.tbxMiddleInitial.Name = "tbxMiddleInitial";
            this.tbxMiddleInitial.Size = new System.Drawing.Size(145, 22);
            this.tbxMiddleInitial.TabIndex = 8;
            // 
            // gbxSection
            // 
            this.gbxSection.BackColor = System.Drawing.Color.Transparent;
            this.gbxSection.Controls.Add(this.lblSection);
            this.gbxSection.Controls.Add(this.lsbSection);
            this.gbxSection.Location = new System.Drawing.Point(12, 371);
            this.gbxSection.Name = "gbxSection";
            this.gbxSection.Size = new System.Drawing.Size(467, 113);
            this.gbxSection.TabIndex = 9;
            this.gbxSection.TabStop = false;
            this.gbxSection.Text = "Section";
            // 
            // lblSection
            // 
            this.lblSection.BackColor = System.Drawing.SystemColors.Control;
            this.lblSection.Location = new System.Drawing.Point(67, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(117, 21);
            this.lblSection.TabIndex = 6;
            this.lblSection.Text = "\r\n";
            // 
            // lsbSection
            // 
            this.lsbSection.BackColor = System.Drawing.SystemColors.Control;
            this.lsbSection.FormattingEnabled = true;
            this.lsbSection.ItemHeight = 14;
            this.lsbSection.Items.AddRange(new object[] {
            "Amethyst",
            "Diamond",
            "Ruby",
            "Sapphire",
            "Emerald"});
            this.lsbSection.Location = new System.Drawing.Point(7, 33);
            this.lsbSection.Name = "lsbSection";
            this.lsbSection.Size = new System.Drawing.Size(177, 74);
            this.lsbSection.TabIndex = 5;
            this.lsbSection.SelectedIndexChanged += new System.EventHandler(this.lsbSection_SelectedIndexChanged);
            // 
            // gbxYearlevel
            // 
            this.gbxYearlevel.BackColor = System.Drawing.Color.Transparent;
            this.gbxYearlevel.Controls.Add(this.label1);
            this.gbxYearlevel.Controls.Add(this.rbtn1st);
            this.gbxYearlevel.Controls.Add(this.rbtn2nd);
            this.gbxYearlevel.Controls.Add(this.rbtn3rd);
            this.gbxYearlevel.Controls.Add(this.rbtn4th);
            this.gbxYearlevel.Location = new System.Drawing.Point(14, 173);
            this.gbxYearlevel.Name = "gbxYearlevel";
            this.gbxYearlevel.Size = new System.Drawing.Size(454, 100);
            this.gbxYearlevel.TabIndex = 10;
            this.gbxYearlevel.TabStop = false;
            this.gbxYearlevel.Text = "Origin";
            this.gbxYearlevel.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(334, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Image = global::Classwork6.Properties.Resources.europe;
            this.label1.Location = new System.Drawing.Point(361, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 41);
            this.label1.TabIndex = 12;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::Classwork6.Properties.Resources.cutie;
            this.ClientSize = new System.Drawing.Size(503, 561);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxYearlevel);
            this.Controls.Add(this.gbxSection);
            this.Controls.Add(this.tbxMiddleInitial);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblMiddleInitial);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.gbxCourse);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmRegistration";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.gbxCourse.ResumeLayout(false);
            this.gbxSection.ResumeLayout(false);
            this.gbxYearlevel.ResumeLayout(false);
            this.gbxYearlevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblFirstName;
        private TextBox tbxFirstName;
        private Label lblMiddleInitial;
        private Label lblLastName;
        private RadioButton rbtn1st;
        private RadioButton rbtn4th;
        private RadioButton rbtn3rd;
        private RadioButton rbtn2nd;
        private GroupBox gbxCourse;
        private ComboBox cbxCourse;
        private Label lblStudentName;
        private TextBox tbxLastName;
        private TextBox tbxMiddleInitial;
        private GroupBox gbxSection;
        private GroupBox gbxYearlevel;
        private Button button1;
        private ListBox lsbSection;
        private Label lblSection;
        private Label label1;
    }
}