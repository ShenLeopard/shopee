using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 蝦皮大家來找碴
{
    public partial class Form2 : Form
    {
        private Image imageA;
        private Image imageB;

        public Form2(Image imageA, Image imageB)
        {
            InitializeComponent();
            this.imageA = imageA;
            this.imageB = imageB;

        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //根據滑桿的位置來決定顯示A圖片還是B圖片的部分
            Bitmap bitmap = new Bitmap(imageA.Width, imageA.Height);
            int position = trackBar1.Value * bitmap.Width / trackBar1.Maximum;
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(imageB, new Rectangle(0, 0, position, bitmap.Height), new Rectangle(0, 0, position, bitmap.Height), GraphicsUnit.Pixel);
                g.DrawImage(imageA, new Rectangle(position, 0, bitmap.Width - position, bitmap.Height), new Rectangle(position, 0, bitmap.Width - position, bitmap.Height), GraphicsUnit.Pixel);
            }
            pictureBox3.Image = bitmap;
        }
    }

}
