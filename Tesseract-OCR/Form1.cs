using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tesseract;

namespace Tesseract_OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void  btnOCR_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog.FileName);
                ///./dataser path of folder contain tranning file.
                var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
                var page = ocr.Process(img);  //Recognition
                txtResult.Text = page.GetText(); //page.GetText() Get text in image. 

                ///寫入文字檔
                DirectoryInfo dir = new DirectoryInfo("G:\\images");
                FileInfo f = new FileInfo("G:\\images\\result.txt");
                if (f.Exists)
                {
                    resultMsg.Text = "已建立文字檔囉!!";
                }
                else
                {
                    dir.Create();
                    resultMsg.Text = "馬上新增建立文字檔!";

                }
                StreamWriter sw = f.CreateText();
                sw.Write(page.GetText()) ;
                sw.Flush();
                sw.Close();


            }

           
        }
    }
}
