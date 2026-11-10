using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrgyInformationSystem
{
    public partial class residentProfileForm : Form
    {
        public residentProfileForm()
        {
            InitializeComponent();
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    picResident.Image = Image.FromFile(openFile.FileName);
                    picResident.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            residentProfileForm editForm = new residentProfileForm();
            editForm.ShowDialog();
        }
    }
}
