using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void ShowB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
        }

        private void BackColorB_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDlg.Color;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
