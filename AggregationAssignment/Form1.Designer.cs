namespace AggregationAssignment
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbClassID = new System.Windows.Forms.GroupBox();
            this.lblChooseClasss = new System.Windows.Forms.Label();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.btnViewInstructor = new System.Windows.Forms.Button();
            this.btnViewRoster = new System.Windows.Forms.Button();
            this.btnCourseDetails = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.pnlSpecs = new System.Windows.Forms.Panel();
            this.gbInstructor = new System.Windows.Forms.GroupBox();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbRoster = new System.Windows.Forms.GroupBox();
            this.rtbStudents = new System.Windows.Forms.RichTextBox();
            this.txtNumStudents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.gbClassID.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlSpecs.SuspendLayout();
            this.gbInstructor.SuspendLayout();
            this.gbRoster.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbClassID);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 94);
            this.panel1.TabIndex = 0;
            // 
            // gbClassID
            // 
            this.gbClassID.Controls.Add(this.lblChooseClasss);
            this.gbClassID.Controls.Add(this.cbClasses);
            this.gbClassID.Location = new System.Drawing.Point(4, 3);
            this.gbClassID.Name = "gbClassID";
            this.gbClassID.Size = new System.Drawing.Size(168, 89);
            this.gbClassID.TabIndex = 0;
            this.gbClassID.TabStop = false;
            this.gbClassID.Text = "Class ID";
            // 
            // lblChooseClasss
            // 
            this.lblChooseClasss.AutoSize = true;
            this.lblChooseClasss.Location = new System.Drawing.Point(6, 24);
            this.lblChooseClasss.Name = "lblChooseClasss";
            this.lblChooseClasss.Size = new System.Drawing.Size(82, 13);
            this.lblChooseClasss.TabIndex = 1;
            this.lblChooseClasss.Text = "Choose a class:";
            // 
            // cbClasses
            // 
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(6, 40);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(155, 21);
            this.cbClasses.TabIndex = 0;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // btnViewInstructor
            // 
            this.btnViewInstructor.Location = new System.Drawing.Point(221, 19);
            this.btnViewInstructor.Name = "btnViewInstructor";
            this.btnViewInstructor.Size = new System.Drawing.Size(109, 23);
            this.btnViewInstructor.TabIndex = 1;
            this.btnViewInstructor.Text = "View Instructor";
            this.btnViewInstructor.UseVisualStyleBackColor = true;
            this.btnViewInstructor.Click += new System.EventHandler(this.btnViewInstructor_Click);
            // 
            // btnViewRoster
            // 
            this.btnViewRoster.Location = new System.Drawing.Point(336, 19);
            this.btnViewRoster.Name = "btnViewRoster";
            this.btnViewRoster.Size = new System.Drawing.Size(109, 23);
            this.btnViewRoster.TabIndex = 2;
            this.btnViewRoster.Text = "View Roster";
            this.btnViewRoster.UseVisualStyleBackColor = true;
            this.btnViewRoster.Click += new System.EventHandler(this.btnViewRoster_Click);
            // 
            // btnCourseDetails
            // 
            this.btnCourseDetails.Location = new System.Drawing.Point(86, 19);
            this.btnCourseDetails.Name = "btnCourseDetails";
            this.btnCourseDetails.Size = new System.Drawing.Size(129, 23);
            this.btnCourseDetails.TabIndex = 3;
            this.btnCourseDetails.Text = "View Course Details";
            this.btnCourseDetails.UseVisualStyleBackColor = true;
            this.btnCourseDetails.Click += new System.EventHandler(this.btnCourseDetails_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnCourseDetails);
            this.pnlNavigation.Controls.Add(this.btnViewInstructor);
            this.pnlNavigation.Controls.Add(this.btnViewRoster);
            this.pnlNavigation.Location = new System.Drawing.Point(245, 12);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(543, 65);
            this.pnlNavigation.TabIndex = 4;
            // 
            // pnlSpecs
            // 
            this.pnlSpecs.Controls.Add(this.gbInstructor);
            this.pnlSpecs.Controls.Add(this.gbRoster);
            this.pnlSpecs.Location = new System.Drawing.Point(245, 87);
            this.pnlSpecs.Name = "pnlSpecs";
            this.pnlSpecs.Size = new System.Drawing.Size(543, 351);
            this.pnlSpecs.TabIndex = 5;
            // 
            // gbInstructor
            // 
            this.gbInstructor.Controls.Add(this.txtOffice);
            this.gbInstructor.Controls.Add(this.txtEmail);
            this.gbInstructor.Controls.Add(this.txtName);
            this.gbInstructor.Controls.Add(this.lblOffice);
            this.gbInstructor.Controls.Add(this.lblEmail);
            this.gbInstructor.Controls.Add(this.lblName);
            this.gbInstructor.Location = new System.Drawing.Point(3, 14);
            this.gbInstructor.Name = "gbInstructor";
            this.gbInstructor.Size = new System.Drawing.Size(251, 151);
            this.gbInstructor.TabIndex = 1;
            this.gbInstructor.TabStop = false;
            this.gbInstructor.Text = "Instructor";
            this.gbInstructor.Visible = false;
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(91, 100);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(137, 20);
            this.txtOffice.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(6, 107);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(82, 13);
            this.lblOffice.TabIndex = 2;
            this.lblOffice.Text = "Office Location:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 69);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // gbRoster
            // 
            this.gbRoster.Controls.Add(this.rtbStudents);
            this.gbRoster.Controls.Add(this.txtNumStudents);
            this.gbRoster.Controls.Add(this.label1);
            this.gbRoster.Location = new System.Drawing.Point(260, 14);
            this.gbRoster.Name = "gbRoster";
            this.gbRoster.Size = new System.Drawing.Size(272, 334);
            this.gbRoster.TabIndex = 0;
            this.gbRoster.TabStop = false;
            this.gbRoster.Text = "Roster";
            this.gbRoster.Visible = false;
            // 
            // rtbStudents
            // 
            this.rtbStudents.Location = new System.Drawing.Point(9, 43);
            this.rtbStudents.Name = "rtbStudents";
            this.rtbStudents.Size = new System.Drawing.Size(257, 285);
            this.rtbStudents.TabIndex = 2;
            this.rtbStudents.Text = "";
            // 
            // txtNumStudents
            // 
            this.txtNumStudents.Location = new System.Drawing.Point(166, 20);
            this.txtNumStudents.Name = "txtNumStudents";
            this.txtNumStudents.Size = new System.Drawing.Size(100, 20);
            this.txtNumStudents.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of students registered.";
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.txtTitle);
            this.pnlDetails.Controls.Add(this.lblTitle);
            this.pnlDetails.Controls.Add(this.txtCredits);
            this.pnlDetails.Controls.Add(this.lblCredits);
            this.pnlDetails.Controls.Add(this.lblDescription);
            this.pnlDetails.Controls.Add(this.rtbDescription);
            this.pnlDetails.Location = new System.Drawing.Point(13, 114);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(226, 324);
            this.pnlDetails.TabIndex = 6;
            this.pnlDetails.Visible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(4, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(206, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(4, 62);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(60, 20);
            this.txtCredits.TabIndex = 3;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(4, 46);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 2;
            this.lblCredits.Text = "Credits";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(4, 97);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(4, 116);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(206, 187);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlSpecs);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Class Info";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.gbClassID.ResumeLayout(false);
            this.gbClassID.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlSpecs.ResumeLayout(false);
            this.gbInstructor.ResumeLayout(false);
            this.gbInstructor.PerformLayout();
            this.gbRoster.ResumeLayout(false);
            this.gbRoster.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbClassID;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Button btnViewInstructor;
        private System.Windows.Forms.Button btnViewRoster;
        private System.Windows.Forms.Label lblChooseClasss;
        private System.Windows.Forms.Button btnCourseDetails;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlSpecs;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.GroupBox gbInstructor;
        private System.Windows.Forms.TextBox txtOffice;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbRoster;
        private System.Windows.Forms.TextBox txtNumStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbStudents;
    }
}

