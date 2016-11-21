using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HTCSplashConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Splash2BMP_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "HTC Splash|*.nb0";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    Splash2BMP(file);
                }
            }
        }

        private void btn_Splash2BMP_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void btn_Splash2BMP_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                if (info.Extension.ToLower() == ".nb0")
                {
                    Splash2BMP(file);
                }
            }
        }

        private void btn_BMP2Splash_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Bitmap|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in openFileDialog1.FileNames)
                {
                    BMP2Splash(file);
                }
            }
        }

        private void btn_BMP2Splash_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void btn_BMP2Splash_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                if (info.Extension.ToLower() == ".bmp")
                {
                    BMP2Splash(file);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100005653172695");
        }

        private void Splash2BMP(string filename)
        {
            FileStream input = File.OpenRead(filename);
            int height = 0, width = 0;
            if (input.Length / 2 >= 3686400)
            {
                height = 2560;
                width = 1440;
            }
            else if (input.Length / 2 >= 2073600)
            {
                height = 1920;
                width = 1080;
            }
            else if (input.Length / 2 >= 921600)
            {
                height = 1280;
                width = 720;
            }
            else if (input.Length / 2 >= 518400)
            {
                height = 960;
                width = 540;
            }
            if (txt_Height.Text.Length > 1 && txt_Width.Text.Length > 1)
            {
                height = Convert.ToInt32(txt_Height.Text);
                width = Convert.ToInt32(txt_Width.Text);
                txt_Height.Clear();
                txt_Width.Clear();
            }
            BinaryReader br = new BinaryReader(input);
            int rowByte = width * 3;
            byte[] bitmapData = new byte[height * rowByte];
            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = 0; j < rowByte; j += 3)
                {
                    UInt16 data = br.ReadUInt16();
                    int R = (data & 0xF800) >> 11;
                    int G = (data & 0x7E0) >> 5;
                    int B = data & 0x1F;
                    R = (R * 255 + 15) / 31;
                    G = (G * 255 + 31) / 63;
                    B = (B * 255 + 15) / 31;
                    int index = i * rowByte + j;
                    bitmapData[index + 0] = (byte)B;
                    bitmapData[index + 1] = (byte)G;
                    bitmapData[index + 2] = (byte)R;
                }
            }
            br.Close();
            input.Close();
            FileStream output = File.Create(filename.Replace(".nb0", ".bmp"));
            BinaryWriter bw = new BinaryWriter(output);
            bw.Write(new byte[] { 0x42, 0x4d });
            bw.Write(bitmapData.Length + 0x36);
            bw.Write(0);
            bw.Write(0x36);
            bw.Write(0x28);
            bw.Write(width);
            bw.Write(height);
            bw.Write((Int16)1);
            bw.Write((Int16)24);
            bw.Write((long)0);
            bw.Write((long)0);
            bw.Write((long)0);
            bw.Write(bitmapData);
            bw.Close();
            output.Close();
        }

        private void BMP2Splash(string filename)
        {
            FileStream input = File.OpenRead(filename);
            BinaryReader br = new BinaryReader(input);
            br.ReadChars(0x12);
            int width = br.ReadInt32();
            int height = br.ReadInt32();
            br.ReadChars(0x2);
            int bitDepth = br.ReadInt16();
            if (bitDepth<24)
            {
                br.Close();
                input.Close();
                MessageBox.Show("Bit Depth under 24 bits NOT supported!");
            }
            br.ReadChars(0x18);
            int rowByte = width * 2;
            byte[] nbData = new byte[height * rowByte];
            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = 0; j < rowByte; j += 2)
                {
                    byte[] pixel = br.ReadBytes(bitDepth >> 3);
                    int R = (pixel[0] * 249 + 1014) >> 11;
                    int G = (pixel[1] * 253 + 505) >> 10;
                    int B = (pixel[2] * 249 + 1014) >> 11;
                    int rgb565 = (B << 11) | (G << 5) | R;
                    int index = i * rowByte + j;
                    nbData[index + 0] = (byte)(rgb565 & 0xFF);
                    nbData[index + 1] = (byte)((rgb565 & 0xFF00) >> 8);
                }
            }
            br.Close();
            input.Close();
            FileStream output = File.Create(filename.Replace(".bmp", ".nb0"));
            BinaryWriter bw = new BinaryWriter(output);
            bw.Write(nbData);
            bw.Close();
            output.Close();
        }
    }
}
