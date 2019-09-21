using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap img = new Bitmap(150, 100);
            Graphics g = Graphics.FromImage(img);
            g.Clear(Color.AliceBlue);
            img.Save(@"C:\17bang\hei.jpg", ImageFormat.Jpeg);

        }

       

    }
  
}
