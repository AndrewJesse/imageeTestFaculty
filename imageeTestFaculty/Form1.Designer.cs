
namespace imageeTestFaculty
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
            this.facultyGroupBox = new System.Windows.Forms.GroupBox();
            this.proceessGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.facultyImageGroupBox = new System.Windows.Forms.GroupBox();
            this.facultyPictureBox = new System.Windows.Forms.PictureBox();
            this.imageCancelButton = new System.Windows.Forms.Button();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listLabeel = new System.Windows.Forms.Label();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startYearTextBox = new System.Windows.Forms.TextBox();
            this.campusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.facultyGroupBox.SuspendLayout();
            this.proceessGroupBox.SuspendLayout();
            this.facultyImageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // facultyGroupBox
            // 
            this.facultyGroupBox.Controls.Add(this.label6);
            this.facultyGroupBox.Controls.Add(this.label5);
            this.facultyGroupBox.Controls.Add(this.campusComboBox);
            this.facultyGroupBox.Controls.Add(this.startYearTextBox);
            this.facultyGroupBox.Controls.Add(this.label4);
            this.facultyGroupBox.Controls.Add(this.label1);
            this.facultyGroupBox.Controls.Add(this.locationTextBox);
            this.facultyGroupBox.Controls.Add(this.degreeTextBox);
            this.facultyGroupBox.Controls.Add(this.proceessGroupBox);
            this.facultyGroupBox.Controls.Add(this.facultyImageGroupBox);
            this.facultyGroupBox.Controls.Add(this.label3);
            this.facultyGroupBox.Controls.Add(this.lastNameTextBox);
            this.facultyGroupBox.Controls.Add(this.titleLabel);
            this.facultyGroupBox.Controls.Add(this.firstNameTextBox);
            this.facultyGroupBox.Controls.Add(this.label2);
            this.facultyGroupBox.Controls.Add(this.listLabeel);
            this.facultyGroupBox.Controls.Add(this.facultyComboBox);
            this.facultyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyGroupBox.Location = new System.Drawing.Point(2, -3);
            this.facultyGroupBox.Name = "facultyGroupBox";
            this.facultyGroupBox.Size = new System.Drawing.Size(709, 504);
            this.facultyGroupBox.TabIndex = 0;
            this.facultyGroupBox.TabStop = false;
            this.facultyGroupBox.Text = "Faculty Portal ";
            this.facultyGroupBox.Enter += new System.EventHandler(this.facultyGroupBox_Enter);
            // 
            // proceessGroupBox
            // 
            this.proceessGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.proceessGroupBox.Controls.Add(this.exitButton);
            this.proceessGroupBox.Controls.Add(this.addButton);
            this.proceessGroupBox.Controls.Add(this.cancelButton);
            this.proceessGroupBox.Controls.Add(this.saveButton);
            this.proceessGroupBox.Location = new System.Drawing.Point(14, 397);
            this.proceessGroupBox.Name = "proceessGroupBox";
            this.proceessGroupBox.Size = new System.Drawing.Size(690, 100);
            this.proceessGroupBox.TabIndex = 23;
            this.proceessGroupBox.TabStop = false;
            this.proceessGroupBox.Text = "Process";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(522, 47);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 23);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "e&Xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(18, 47);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 23);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(347, 47);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 23);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(174, 47);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // facultyImageGroupBox
            // 
            this.facultyImageGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.facultyImageGroupBox.Controls.Add(this.facultyPictureBox);
            this.facultyImageGroupBox.Controls.Add(this.imageCancelButton);
            this.facultyImageGroupBox.Controls.Add(this.pictureLabel);
            this.facultyImageGroupBox.Controls.Add(this.loadImageButton);
            this.facultyImageGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facultyImageGroupBox.Location = new System.Drawing.Point(381, 105);
            this.facultyImageGroupBox.Name = "facultyImageGroupBox";
            this.facultyImageGroupBox.Size = new System.Drawing.Size(323, 277);
            this.facultyImageGroupBox.TabIndex = 22;
            this.facultyImageGroupBox.TabStop = false;
            this.facultyImageGroupBox.Text = "Faculty File Image";
            // 
            // facultyPictureBox
            // 
            this.facultyPictureBox.Location = new System.Drawing.Point(117, 33);
            this.facultyPictureBox.Name = "facultyPictureBox";
            this.facultyPictureBox.Size = new System.Drawing.Size(97, 126);
            this.facultyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facultyPictureBox.TabIndex = 4;
            this.facultyPictureBox.TabStop = false;
            // 
            // imageCancelButton
            // 
            this.imageCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageCancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageCancelButton.Location = new System.Drawing.Point(171, 209);
            this.imageCancelButton.Name = "imageCancelButton";
            this.imageCancelButton.Size = new System.Drawing.Size(134, 23);
            this.imageCancelButton.TabIndex = 7;
            this.imageCancelButton.Text = "Cancel Image Load";
            this.imageCancelButton.UseVisualStyleBackColor = true;
            this.imageCancelButton.Click += new System.EventHandler(this.imageCancelButton_Click);
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureLabel.Location = new System.Drawing.Point(6, 162);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(314, 18);
            this.pictureLabel.TabIndex = 5;
            this.pictureLabel.Text = "picture                                                                          " +
    "              ";
            this.pictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadImageButton.Location = new System.Drawing.Point(6, 208);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(146, 24);
            this.loadImageButton.TabIndex = 6;
            this.loadImageButton.Text = "Load Faculty Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(14, 193);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(329, 20);
            this.lastNameTextBox.TabIndex = 20;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(274, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(164, 25);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Faculty Profile";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(14, 151);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(329, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // listLabeel
            // 
            this.listLabeel.AutoSize = true;
            this.listLabeel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabeel.Location = new System.Drawing.Point(10, 82);
            this.listLabeel.Name = "listLabeel";
            this.listLabeel.Size = new System.Drawing.Size(143, 16);
            this.listLabeel.TabIndex = 1;
            this.listLabeel.Text = "List of faculty Members";
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Location = new System.Drawing.Point(14, 105);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(329, 24);
            this.facultyComboBox.TabIndex = 0;
            this.facultyComboBox.SelectedIndexChanged += new System.EventHandler(this.facultyComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 20);
            this.textBox1.TabIndex = 4;
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.BackColor = System.Drawing.Color.White;
            this.degreeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeTextBox.Location = new System.Drawing.Point(14, 235);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.ReadOnly = true;
            this.degreeTextBox.Size = new System.Drawing.Size(329, 20);
            this.degreeTextBox.TabIndex = 24;
            // 
            // locationTextBox
            // 
            this.locationTextBox.BackColor = System.Drawing.Color.White;
            this.locationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(14, 277);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(329, 20);
            this.locationTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Degree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Location";
            // 
            // startYearTextBox
            // 
            this.startYearTextBox.BackColor = System.Drawing.Color.White;
            this.startYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startYearTextBox.Location = new System.Drawing.Point(14, 362);
            this.startYearTextBox.Name = "startYearTextBox";
            this.startYearTextBox.ReadOnly = true;
            this.startYearTextBox.Size = new System.Drawing.Size(148, 20);
            this.startYearTextBox.TabIndex = 28;
            // 
            // campusComboBox
            // 
            this.campusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campusComboBox.Enabled = false;
            this.campusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campusComboBox.FormattingEnabled = true;
            this.campusComboBox.ItemHeight = 13;
            this.campusComboBox.Items.AddRange(new object[] {
            "Cascade",
            "Rock Creek",
            "Southeast",
            "Sylvania"});
            this.campusComboBox.Location = new System.Drawing.Point(14, 319);
            this.campusComboBox.Name = "campusComboBox";
            this.campusComboBox.Size = new System.Drawing.Size(121, 21);
            this.campusComboBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Start Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Campus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 506);
            this.Controls.Add(this.facultyGroupBox);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Portal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.facultyGroupBox.ResumeLayout(false);
            this.facultyGroupBox.PerformLayout();
            this.proceessGroupBox.ResumeLayout(false);
            this.facultyImageGroupBox.ResumeLayout(false);
            this.facultyImageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox facultyGroupBox;
        private System.Windows.Forms.ComboBox facultyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label listLabeel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button imageCancelButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.PictureBox facultyPictureBox;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox facultyImageGroupBox;
        private System.Windows.Forms.GroupBox proceessGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox campusComboBox;
        private System.Windows.Forms.TextBox startYearTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
    }
}

