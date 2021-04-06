using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;

namespace WindowsFormsApp2.Classss
{
  public class LoagIMG
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
    }
}
