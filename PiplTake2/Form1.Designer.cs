namespace PiplTake2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailResult = new System.Windows.Forms.TextBox();
            this.pBoxPhoto1 = new System.Windows.Forms.PictureBox();
            this.txtImage1 = new System.Windows.Forms.TextBox();
            this.cbJobResults = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResultsCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResultsLeft2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find Person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Results:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtJobResult
            // 
            this.txtJobResult.BackColor = System.Drawing.Color.LightGray;
            this.txtJobResult.Location = new System.Drawing.Point(113, 58);
            this.txtJobResult.Name = "txtJobResult";
            this.txtJobResult.Size = new System.Drawing.Size(544, 20);
            this.txtJobResult.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtResultsLeft2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtResultsCount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPhoneResult);
            this.groupBox1.Controls.Add(this.cbJobResults);
            this.groupBox1.Controls.Add(this.txtImage1);
            this.groupBox1.Controls.Add(this.pBoxPhoto1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmailResult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtJobResult);
            this.groupBox1.Location = new System.Drawing.Point(433, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 451);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(112, 33);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 4;
            this.txtFirstname.Text = "Anthony";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(112, 66);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.Text = "Kendrick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(112, 213);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 8;
            this.txtCity.Text = "Sydney";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(112, 245);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 10;
            this.txtState.Text = "NSW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(112, 278);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 12;
            this.txtCountry.Text = "AU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.txtState);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCountry);
            this.groupBox2.Controls.Add(this.txtFirstname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 451);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Email result:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtEmailResult
            // 
            this.txtEmailResult.BackColor = System.Drawing.Color.LightGray;
            this.txtEmailResult.Location = new System.Drawing.Point(113, 111);
            this.txtEmailResult.Name = "txtEmailResult";
            this.txtEmailResult.Size = new System.Drawing.Size(544, 20);
            this.txtEmailResult.TabIndex = 4;
            this.txtEmailResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pBoxPhoto1
            // 
            this.pBoxPhoto1.Location = new System.Drawing.Point(96, 175);
            this.pBoxPhoto1.Name = "pBoxPhoto1";
            this.pBoxPhoto1.Size = new System.Drawing.Size(255, 240);
            this.pBoxPhoto1.TabIndex = 5;
            this.pBoxPhoto1.TabStop = false;
            // 
            // txtImage1
            // 
            this.txtImage1.BackColor = System.Drawing.Color.LightGray;
            this.txtImage1.Location = new System.Drawing.Point(138, 421);
            this.txtImage1.Name = "txtImage1";
            this.txtImage1.Size = new System.Drawing.Size(164, 20);
            this.txtImage1.TabIndex = 6;
            this.txtImage1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cbJobResults
            // 
            this.cbJobResults.BackColor = System.Drawing.Color.LightGray;
            this.cbJobResults.FormattingEnabled = true;
            this.cbJobResults.Location = new System.Drawing.Point(113, 84);
            this.cbJobResults.Name = "cbJobResults";
            this.cbJobResults.Size = new System.Drawing.Size(544, 21);
            this.cbJobResults.TabIndex = 7;
            this.cbJobResults.SelectedIndexChanged += new System.EventHandler(this.cbJobResults_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone result:";
            // 
            // txtPhoneResult
            // 
            this.txtPhoneResult.BackColor = System.Drawing.Color.LightGray;
            this.txtPhoneResult.Location = new System.Drawing.Point(111, 140);
            this.txtPhoneResult.Name = "txtPhoneResult";
            this.txtPhoneResult.Size = new System.Drawing.Size(546, 20);
            this.txtPhoneResult.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Persons found";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtResultsCount
            // 
            this.txtResultsCount.BackColor = System.Drawing.Color.LightGray;
            this.txtResultsCount.Location = new System.Drawing.Point(509, 16);
            this.txtResultsCount.Name = "txtResultsCount";
            this.txtResultsCount.Size = new System.Drawing.Size(148, 20);
            this.txtResultsCount.TabIndex = 11;
            this.txtResultsCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Demo results left:";
            // 
            // txtResultsLeft2
            // 
            this.txtResultsLeft2.BackColor = System.Drawing.Color.LightGray;
            this.txtResultsLeft2.Location = new System.Drawing.Point(168, 19);
            this.txtResultsLeft2.Name = "txtResultsLeft2";
            this.txtResultsLeft2.Size = new System.Drawing.Size(148, 20);
            this.txtResultsLeft2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJobResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailResult;
        private System.Windows.Forms.PictureBox pBoxPhoto1;
        private System.Windows.Forms.TextBox txtImage1;
        private System.Windows.Forms.ComboBox cbJobResults;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResultsCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResultsLeft2;
    }
}

