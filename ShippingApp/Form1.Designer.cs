namespace ShippingApp
{
    partial class ShippingAppMainPage
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
            pictureBox1 = new PictureBox();
            deleteSelectedImageBtn = new Button();
            cameraOnBtn = new Button();
            submitBtn = new Button();
            takePhotoBtn = new Button();
            listBox1 = new ListBox();
            cameraListBox = new ComboBox();
            imageNameLbl = new Label();
            pictureBox2 = new PictureBox();
            addImageBtn = new Button();
            fileNameTxtBx = new TextBox();
            clearBtn = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            sButton1 = new Styling_Toggle_Button.SButton();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(84, 132);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1048, 935);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // deleteSelectedImageBtn
            // 
            deleteSelectedImageBtn.Location = new Point(2357, 132);
            deleteSelectedImageBtn.Margin = new Padding(4, 5, 4, 5);
            deleteSelectedImageBtn.Name = "deleteSelectedImageBtn";
            deleteSelectedImageBtn.Size = new Size(209, 38);
            deleteSelectedImageBtn.TabIndex = 23;
            deleteSelectedImageBtn.Text = "Delete Selected Image";
            deleteSelectedImageBtn.UseVisualStyleBackColor = true;
            deleteSelectedImageBtn.Click += deleteSelectedImageBtn_Click;
            // 
            // cameraOnBtn
            // 
            cameraOnBtn.Location = new Point(84, 58);
            cameraOnBtn.Margin = new Padding(4, 5, 4, 5);
            cameraOnBtn.Name = "cameraOnBtn";
            cameraOnBtn.Size = new Size(170, 38);
            cameraOnBtn.TabIndex = 12;
            cameraOnBtn.Text = "Turn Camera On";
            cameraOnBtn.UseVisualStyleBackColor = true;
            cameraOnBtn.Click += cameraOnBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(1986, 1511);
            submitBtn.Margin = new Padding(4, 5, 4, 5);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(580, 130);
            submitBtn.TabIndex = 22;
            submitBtn.Text = "Submit Shipment Images";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // takePhotoBtn
            // 
            takePhotoBtn.Location = new Point(430, 1177);
            takePhotoBtn.Margin = new Padding(4, 5, 4, 5);
            takePhotoBtn.Name = "takePhotoBtn";
            takePhotoBtn.Size = new Size(281, 150);
            takePhotoBtn.TabIndex = 13;
            takePhotoBtn.Text = "Take Image";
            takePhotoBtn.UseVisualStyleBackColor = true;
            takePhotoBtn.Click += takePhotoBtn_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1986, 182);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(578, 504);
            listBox1.TabIndex = 21;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // cameraListBox
            // 
            cameraListBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cameraListBox.FormattingEnabled = true;
            cameraListBox.Location = new Point(263, 58);
            cameraListBox.Margin = new Padding(4, 5, 4, 5);
            cameraListBox.Name = "cameraListBox";
            cameraListBox.Size = new Size(235, 33);
            cameraListBox.TabIndex = 15;
            // 
            // imageNameLbl
            // 
            imageNameLbl.AutoSize = true;
            imageNameLbl.Location = new Point(1280, 790);
            imageNameLbl.Margin = new Padding(4, 0, 4, 0);
            imageNameLbl.Name = "imageNameLbl";
            imageNameLbl.Size = new Size(118, 25);
            imageNameLbl.TabIndex = 20;
            imageNameLbl.Text = "Image Name:";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(1214, 132);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(702, 550);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // addImageBtn
            // 
            addImageBtn.Location = new Point(1414, 870);
            addImageBtn.Margin = new Padding(4, 5, 4, 5);
            addImageBtn.Name = "addImageBtn";
            addImageBtn.Size = new Size(281, 150);
            addImageBtn.TabIndex = 19;
            addImageBtn.Text = "Add Image";
            addImageBtn.UseVisualStyleBackColor = true;
            addImageBtn.Click += addImageBtn_Click;
            // 
            // fileNameTxtBx
            // 
            fileNameTxtBx.Location = new Point(1400, 778);
            fileNameTxtBx.Margin = new Padding(4, 5, 4, 5);
            fileNameTxtBx.Name = "fileNameTxtBx";
            fileNameTxtBx.Size = new Size(265, 31);
            fileNameTxtBx.TabIndex = 17;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(1676, 777);
            clearBtn.Margin = new Padding(4, 5, 4, 5);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(107, 38);
            clearBtn.TabIndex = 18;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1986, 777);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(578, 464);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1986, 747);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 25;
            label1.Text = "Notes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1214, 1065);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(559, 45);
            label2.TabIndex = 26;
            label2.Text = "• Include Image(s) of shipping label(s)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 38);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1214, 1147);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(528, 45);
            label4.TabIndex = 27;
            label4.Text = "• Include image(s) of sealed box(es)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(1214, 1223);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(748, 45);
            label5.TabIndex = 28;
            label5.Text = "• Include Image(s) of box(es) contents pre-package";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(1214, 1303);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(764, 45);
            label6.TabIndex = 29;
            label6.Text = "• Include Image(s) of box(es) contents post-package";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(1214, 1380);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(477, 45);
            label7.TabIndex = 30;
            label7.Text = "• Include notes on the shipment";
            // 
            // sButton1
            // 
            sButton1.Location = new Point(2117, 1326);
            sButton1.MinimumSize = new Size(45, 22);
            sButton1.Name = "sButton1";
            sButton1.OffBackColor = Color.Gray;
            sButton1.OffToggleColor = Color.Gainsboro;
            sButton1.OnBackColor = Color.MediumSlateBlue;
            sButton1.OnToggleColor = Color.WhiteSmoke;
            sButton1.Size = new Size(299, 126);
            sButton1.TabIndex = 32;
            sButton1.UseVisualStyleBackColor = true;
            sButton1.CheckedChanged += sButton1_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1986, 1376);
            label8.Name = "label8";
            label8.Size = new Size(126, 38);
            label8.TabIndex = 33;
            label8.Text = "Shipping";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(2431, 1380);
            label9.Name = "label9";
            label9.Size = new Size(135, 38);
            label9.TabIndex = 34;
            label9.Text = "Receiving";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.IndianRed;
            label10.Location = new Point(1414, 25);
            label10.Name = "label10";
            label10.Size = new Size(273, 70);
            label10.TabIndex = 35;
            label10.Text = "SHIPPING";
            // 
            // ShippingAppMainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(2743, 1800);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(sButton1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(deleteSelectedImageBtn);
            Controls.Add(cameraOnBtn);
            Controls.Add(submitBtn);
            Controls.Add(takePhotoBtn);
            Controls.Add(listBox1);
            Controls.Add(cameraListBox);
            Controls.Add(imageNameLbl);
            Controls.Add(pictureBox2);
            Controls.Add(addImageBtn);
            Controls.Add(fileNameTxtBx);
            Controls.Add(clearBtn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ShippingAppMainPage";
            Text = "mainPage";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            FormClosing += ShippingAppMainPage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button deleteSelectedImageBtn;
        private Button cameraOnBtn;
        private Button submitBtn;
        private Button takePhotoBtn;
        private ListBox listBox1;
        private ComboBox cameraListBox;
        private Label imageNameLbl;
        private PictureBox pictureBox2;
        private Button addImageBtn;
        private TextBox fileNameTxtBx;
        private Button clearBtn;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Styling_Toggle_Button.SButton sButton1;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}