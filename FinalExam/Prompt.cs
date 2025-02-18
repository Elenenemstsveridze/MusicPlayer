using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalExam
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 330,
                Height = 210,
                BackColor = Color.LightSkyBlue,
                Text = caption
            };

            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Text = text
            };
            TextBox inputBox = new TextBox()
            {
                Left = 20,
                Top = 50,
                Width = 240
            };
            Button confirmation = new Button()
            {
                Text = "Ok",
                Left = 150,
                Width = 100,
                Height = 40,
                Top = 100,
                ForeColor = Color.White,
                DialogResult = DialogResult.OK 
            };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);

            prompt.StartPosition = FormStartPosition.CenterParent;
            prompt.ShowDialog();
            return inputBox.Text;
        }
    }
}
