namespace FinalExam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ConfirmPasswordTxt = new TextBox();
            UsernameSignUpTxt = new TextBox();
            PasswordSignUpTxt = new TextBox();
            SignUpButton = new Button();
            panel2 = new Panel();
            label7 = new Label();
            PasswordSignInTxt = new TextBox();
            label8 = new Label();
            UsernameSignInTxt = new TextBox();
            SignInButton = new Button();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(131, 33);
            label1.Name = "label1";
            label1.Size = new Size(107, 35);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(123, 33);
            label2.Name = "label2";
            label2.Size = new Size(118, 35);
            label2.TabIndex = 1;
            label2.Text = "Sign Up";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ConfirmPasswordTxt);
            panel1.Controls.Add(UsernameSignUpTxt);
            panel1.Controls.Add(PasswordSignUpTxt);
            panel1.Controls.Add(SignUpButton);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(25, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 498);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(101, 304);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 7;
            label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(133, 207);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 6;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(129, 108);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 4;
            label4.Text = "Username:";
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.Location = new Point(83, 345);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.Size = new Size(192, 31);
            ConfirmPasswordTxt.TabIndex = 5;
            // 
            // UsernameSignUpTxt
            // 
            UsernameSignUpTxt.Location = new Point(83, 157);
            UsernameSignUpTxt.Name = "UsernameSignUpTxt";
            UsernameSignUpTxt.Size = new Size(192, 31);
            UsernameSignUpTxt.TabIndex = 4;
            // 
            // PasswordSignUpTxt
            // 
            PasswordSignUpTxt.Location = new Point(83, 247);
            PasswordSignUpTxt.Name = "PasswordSignUpTxt";
            PasswordSignUpTxt.Size = new Size(192, 31);
            PasswordSignUpTxt.TabIndex = 3;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.DeepSkyBlue;
            SignUpButton.FlatAppearance.BorderColor = Color.Blue;
            SignUpButton.FlatAppearance.BorderSize = 0;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.ForeColor = SystemColors.ButtonHighlight;
            SignUpButton.Location = new Point(83, 420);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(192, 56);
            SignUpButton.TabIndex = 2;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(PasswordSignInTxt);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(UsernameSignInTxt);
            panel2.Controls.Add(SignInButton);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(410, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 498);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(135, 240);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 9;
            label7.Text = "Password:";
            // 
            // PasswordSignInTxt
            // 
            PasswordSignInTxt.Location = new Point(87, 278);
            PasswordSignInTxt.Name = "PasswordSignInTxt";
            PasswordSignInTxt.Size = new Size(192, 31);
            PasswordSignInTxt.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(131, 141);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 8;
            label8.Text = "Username:";
            // 
            // UsernameSignInTxt
            // 
            UsernameSignInTxt.Location = new Point(87, 187);
            UsernameSignInTxt.Name = "UsernameSignInTxt";
            UsernameSignInTxt.Size = new Size(192, 31);
            UsernameSignInTxt.TabIndex = 5;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.DeepSkyBlue;
            SignInButton.FlatAppearance.BorderColor = Color.Blue;
            SignInButton.FlatAppearance.BorderSize = 0;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignInButton.ForeColor = SystemColors.ButtonHighlight;
            SignInButton.Location = new Point(87, 420);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(192, 56);
            SignInButton.TabIndex = 3;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(177, 28);
            label3.Name = "label3";
            label3.Size = new Size(450, 35);
            label3.TabIndex = 2;
            label3.Text = "Sign Up or Sign In for your music!";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox1);
            panel3.ForeColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(25, 615);
            panel3.Name = "panel3";
            panel3.Size = new Size(750, 178);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\User\\source\\repos\\FinalExam\\FinalExam\\Resources\\1366x768-audio-wave-5692234-4798534.gif";
            pictureBox1.Location = new Point(71, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 815);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Button SignUpButton;
        private Button SignInButton;
        private TextBox ConfirmPasswordTxt;
        private TextBox UsernameSignUpTxt;
        private TextBox PasswordSignUpTxt;
        private TextBox PasswordSignInTxt;
        private TextBox UsernameSignInTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
    }
}
