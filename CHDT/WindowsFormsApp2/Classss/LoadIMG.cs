using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using System.IO;

namespace WindowsFormsApp2.Classss
{
  public class LoadIMG
    {
        public Image loadImg(string url)
        {
            WebRequest req = WebRequest.Create(url);
            using (var response = req.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    return Bitmap.FromStream(str);
                }
            }
        }

        public static Image ByteToImg(byte[] imgBytes)
        {
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }


        public static byte[] converImgToByte(string urlFile)
        {
            FileStream fs;
            fs = new FileStream(urlFile, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
    }
}
