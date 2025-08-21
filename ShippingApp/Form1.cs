using AForge.Video;
using AForge.Video.DirectShow;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ShippingApp
{
    public partial class ShippingAppMainPage : Form
    {
        public ShippingAppMainPage()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.FromArgb(0, 164, 239); // #00A4EF blue

            LoadCameraList();
        }

        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;

        List<Bitmap> shipmentImages = new List<Bitmap>();
        List<string> imageNames = new List<string>();
        string filePath = @"M:\shipping_and_receiving\";

        void LoadCameraList()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                //cameraListBox.Text = filterInfo[0].Name.ToString();

                foreach (FilterInfo dev in filterInfo)
                {
                    cameraListBox.Items.Add(dev.Name);
                }

                cameraListBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void StartCamera(string cameraName)
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                foreach (FilterInfo dev in filterInfo)
                {
                    if (dev.Name == cameraName)
                    {
                        videoCapture = new VideoCaptureDevice(dev.MonikerString);
                    }
                }

                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                videoCapture.Start();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void takePhotoBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void ShippingAppMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                videoCapture.Stop();
            }
            catch
            {
                return;
            }
        }

        private void cameraOnBtn_Click(object sender, EventArgs e)
        {
            var cameraName = cameraListBox.Text;
            StartCamera(cameraName);
        }

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            pictureBox2.DrawToBitmap(bitmap, pictureBox2.ClientRectangle);
            shipmentImages.Add(bitmap);

            bool fileNameValid = TryValidateFilename(fileNameTxtBx.Text);

            if ((fileNameTxtBx.Text == ""))
            {
                fileNameTxtBx.Text = "unamed orphen";

                imageNames.Add(fileNameTxtBx.Text);
                listBox1.Items.Add(fileNameTxtBx.Text + ".jpg");

                fileNameTxtBx.Text = "";
            }
            else if (fileNameValid == false)
            {

                fileNameTxtBx.Text = "invalidFilenameUsed";

                imageNames.Add(fileNameTxtBx.Text);
                listBox1.Items.Add(fileNameTxtBx.Text + ".jpg");
            }

            else
            {
                imageNames.Add(fileNameTxtBx.Text);
                listBox1.Items.Add(fileNameTxtBx.Text + ".jpg");
            }
        }

        private void deleteSelectedImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var indexOfSelectedItem = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(indexOfSelectedItem);
                imageNames.RemoveAt(indexOfSelectedItem);
                shipmentImages.RemoveAt(indexOfSelectedItem);
            }
            catch
            {
                return;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var indexOfSelectedItem = listBox1.SelectedIndex;
                pictureBox2.Image = shipmentImages[indexOfSelectedItem];
            }
            catch
            {
                return;
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            fileNameTxtBx.Text = "";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now; // Or any other DateTime object
            string yearString = date.ToString("yyyy"); // "yyyy" represents a four-digit year
            string yearMonthMinString = date.ToString("yyyy_MM_dd");
            string timeString = date.ToString("hh_mm_ss_t");
            string tempFilePath = filePath + yearString + "\\" + yearMonthMinString + "\\" + timeString + "\\";
            Directory.CreateDirectory(tempFilePath);

            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            for (int i = 0; i < shipmentImages.Count; i++)
            {
                shipmentImages[i].Save((tempFilePath + imageNames[i] + "_" + i.ToString() + ".jpg"), imageFormat);
            }


            // Save the contents of the RichTextBox to the selected file as plain text
            richTextBox1.SaveFile(tempFilePath + "shipping_notes.txt", RichTextBoxStreamType.PlainText);



            listBox1.Items.Clear();
            richTextBox1.Text = "";

            //MessageBox.Show("Fantastic!");

        }

        public static bool TryValidateFilename(string filename)
        {
            if (filename.IndexOfAny(Path.GetInvalidFileNameChars()) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!sButton1.Checked)
            {
                this.BackColor = System.Drawing.Color.FromArgb(0, 164, 239); // #00A4EF blue
                label10.Text = "SHIPPING";
                label10.ForeColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(255, 185, 0);// '#FFB900'; yellow
                label10.Text = "RECEIVING";
                label10.ForeColor = System.Drawing.Color.IndianRed;
            }
        }
    }
}