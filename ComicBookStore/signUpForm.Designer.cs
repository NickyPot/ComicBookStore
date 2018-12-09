namespace ComicBookStore
{
    partial class signUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.batmanCheckBox1 = new System.Windows.Forms.CheckBox();
            this.supermanCheckBox2 = new System.Windows.Forms.CheckBox();
            this.spidermanCheckBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Home Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(120, 19);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.Location = new System.Drawing.Point(120, 113);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeAddressTextBox.TabIndex = 8;
            this.homeAddressTextBox.TextChanged += new System.EventHandler(this.homeAddressTextBox_TextChanged);
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Location = new System.Drawing.Point(120, 81);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumTextBox.TabIndex = 10;
            this.phoneNumTextBox.TextChanged += new System.EventHandler(this.phoneNumTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sign Up!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(120, 51);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Avatar:";
            // 
            // batmanCheckBox1
            // 
            this.batmanCheckBox1.AutoSize = true;
            this.batmanCheckBox1.Location = new System.Drawing.Point(120, 156);
            this.batmanCheckBox1.Name = "batmanCheckBox1";
            this.batmanCheckBox1.Size = new System.Drawing.Size(62, 17);
            this.batmanCheckBox1.TabIndex = 15;
            this.batmanCheckBox1.Text = "Batman";
            this.batmanCheckBox1.UseVisualStyleBackColor = true;
            this.batmanCheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // supermanCheckBox2
            // 
            this.supermanCheckBox2.AutoSize = true;
            this.supermanCheckBox2.Location = new System.Drawing.Point(120, 180);
            this.supermanCheckBox2.Name = "supermanCheckBox2";
            this.supermanCheckBox2.Size = new System.Drawing.Size(74, 17);
            this.supermanCheckBox2.TabIndex = 16;
            this.supermanCheckBox2.Text = "Superman";
            this.supermanCheckBox2.UseVisualStyleBackColor = true;
            this.supermanCheckBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // spidermanCheckBox3
            // 
            this.spidermanCheckBox3.AutoSize = true;
            this.spidermanCheckBox3.Location = new System.Drawing.Point(120, 204);
            this.spidermanCheckBox3.Name = "spidermanCheckBox3";
            this.spidermanCheckBox3.Size = new System.Drawing.Size(76, 17);
            this.spidermanCheckBox3.TabIndex = 17;
            this.spidermanCheckBox3.Text = "Spiderman";
            this.spidermanCheckBox3.UseVisualStyleBackColor = true;
            this.spidermanCheckBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.spidermanCheckBox3);
            this.Controls.Add(this.supermanCheckBox2);
            this.Controls.Add(this.batmanCheckBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(this.homeAddressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox batmanCheckBox1;
        private System.Windows.Forms.CheckBox supermanCheckBox2;
        private System.Windows.Forms.CheckBox spidermanCheckBox3;
    }
}