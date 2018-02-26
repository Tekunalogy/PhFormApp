using System;
using System.Drawing;
using System.Windows.Forms;
using Syroot.Windows.IO;
using System.IO;
using System.Threading;

namespace PhFormApp
{
    public partial class PhForm : Form
    {
        public PhForm()
        {
            InitializeComponent();
            ColorButton1.Location = new Point(30 , 200);
            ColorButton3.Location = new Point(150 , 200);
            ColorButton5.Location = new Point(270 , 200);
            ColorButton7.Location = new Point(390 , 200);
            ColorButton9.Location = new Point(520 , 200);
            ColorButton2.Location = new Point(30 , 300);
            ColorButton4.Location = new Point(150 , 300);
            ColorButton6.Location = new Point(270 , 300);
            ColorButton8.Location = new Point(390 , 300);
            ColorButton10.Location = new Point(520 , 300);

        }

        private string filep = "";
        private Boolean checkFileUploadStatus = false;

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";
            string startPath = KnownFolders.Downloads.ToString();
            dialog.InitialDirectory = startPath;
            dialog.Title = "Please select an image file to upload.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filep = dialog.FileName;
            }
            else
            {
                return;
            }

            Bitmap bMap = Bitmap.FromFile(filep) as Bitmap;

            if (bMap == null) throw new FileNotFoundException("Cannot open picture file for analysis");

            checkFileUploadStatus = true;

            PictureProcess.GetMostUsedColor(bMap);
            checkFileUploadStatus = true;
            ColorButton1.BackColor = PictureProcess.TenMostUsedColors[0];
            ColorButton2.BackColor = PictureProcess.TenMostUsedColors[1];
            ColorButton3.BackColor = PictureProcess.TenMostUsedColors[2];
            ColorButton4.BackColor = PictureProcess.TenMostUsedColors[3];
            ColorButton5.BackColor = PictureProcess.TenMostUsedColors[4];
            ColorButton6.BackColor = PictureProcess.TenMostUsedColors[5];
            ColorButton7.BackColor = PictureProcess.TenMostUsedColors[6];
            ColorButton8.BackColor = PictureProcess.TenMostUsedColors[7];
            ColorButton9.BackColor = PictureProcess.TenMostUsedColors[8];
            ColorButton10.BackColor = PictureProcess.TenMostUsedColors[9];


        }

        public static Color colorToSend = Color.Empty;
        Thread newThread;

        private void openNewForm(object obj)
        {
            Application.Run(new PhProcess());
        }

        private void ColorButton2_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton2.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }

        private void ColorButton9_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton9.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }

        private void ColorButton8_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton8.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start(); ;
            }
        }

        private void ColorButton7_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton7.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }

        private void ColorButton6_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton6.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }

        private void ColorButton5_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton5.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }

        private void ColorButton4_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton4.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }

        private void ColorButton3_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton3.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }

        private void ColorButton10_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton10.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }

        private void ColorButton1_Click(object sender, EventArgs e)
        {
            if (checkFileUploadStatus != true)
            {
                ErrorLabel.Text = "ERROR: Please Upload File before choosing color";
                for (int i = 0; i < 2; i++)
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.ForeColor = Color.Black;
                }
            }
            else
            {
                colorToSend = ColorButton1.BackColor;
                this.Close();
                newThread = new Thread(openNewForm);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            }
        }
    }
}
