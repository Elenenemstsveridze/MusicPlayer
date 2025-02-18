namespace FinalExam
{
    partial class MusicSelection
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
            checkedListBoxSongs = new CheckedListBox();
            buttonOK = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkedListBoxSongs
            // 
            checkedListBoxSongs.FormattingEnabled = true;
            checkedListBoxSongs.Location = new Point(25, 108);
            checkedListBoxSongs.Name = "checkedListBoxSongs";
            checkedListBoxSongs.Size = new Size(366, 368);
            checkedListBoxSongs.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.DeepSkyBlue;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.ForeColor = SystemColors.ButtonHighlight;
            buttonOK.Location = new Point(271, 499);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(120, 51);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(80, 47);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 2;
            label1.Text = "Choose your Music!";
            // 
            // MusicSelection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(419, 562);
            Controls.Add(label1);
            Controls.Add(buttonOK);
            Controls.Add(checkedListBoxSongs);
            Name = "MusicSelection";
            Text = "MusicSelection";
            Load += MusicSelection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxSongs;
        private Button buttonOK;
        private Label label1;
    }
}