using Guna.UI.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WordpadKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            allignLeft.BaseColor = Color.FromArgb(248, 112, 96);
            allignLeft.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            foreach (var fontFamily in FontFamily.Families)
            {
                fontBox.Items.Add(fontFamily.Name.ToString());
            }

            for (int i = 8; i <= 100; i += 2)
            {
                fontSizeBox.Items.Add(i);
            }

            fontSizeBox.SelectedIndex = 0;
            fontBox.SelectedIndex = 0;
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void fontBox_DropDown(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(fontDialog1.Font.Name);
            }
        }

        private void fontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(fontBox.Text, int.Parse(fontSizeBox.Text));
        }

        private void fontSizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(fontBox.Text, int.Parse(fontSizeBox.Text));
        }

        private void allignLeft_Click(object sender, EventArgs e)
        {
            allignCenter.BaseColor = Color.White;
            allignCenter.ForeColor = Color.Black;

            allignRight.BaseColor = Color.White;
            allignRight.ForeColor = Color.Black;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            allignLeft.BaseColor = Color.FromArgb(248, 112, 96);
            allignLeft.ForeColor = Color.White;
        }

        private void allignCenter_Click(object sender, EventArgs e)
        {
            allignLeft.BaseColor = Color.White;
            allignLeft.ForeColor = Color.Black;

            allignRight.BaseColor = Color.White;
            allignRight.ForeColor = Color.Black;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            allignCenter.BaseColor = Color.FromArgb(248, 112, 96);
            allignCenter.ForeColor = Color.White;
        }

        private void allignRight_Click(object sender, EventArgs e)
        {
            allignLeft.BaseColor = Color.White;
            allignLeft.ForeColor = Color.Black;

            allignCenter.BaseColor = Color.White;
            allignCenter.ForeColor = Color.Black;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            allignRight.BaseColor = Color.FromArgb(248, 112, 96);
            allignRight.ForeColor = Color.White;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;
            sfd.CreatePrompt = true;
            sfd.FileName = "text1";
            sfd.Filter = "Normal Text Format (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            sfd.FilterIndex = 0;


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }

        private void saveBox_Click(object sender, EventArgs e)
        {
            if (saveBox.Text == "Enter name and save")
            {
                saveBox.Text = String.Empty;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                string text = File.ReadAllText(file);
                richTextBox1.Text = text;
            }
        }

        private void fontStyle_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (bold.Checked && underline.Checked && italic.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            else if (bold.Checked && underline.Checked)
            {

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Underline);
            }
            else if (bold.Checked && italic.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic);
            }
            else if (underline.Checked && italic.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Italic);
            }
            else if (bold.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            }
            else if (underline.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            }
            else if (italic.Checked)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }
    }
}
