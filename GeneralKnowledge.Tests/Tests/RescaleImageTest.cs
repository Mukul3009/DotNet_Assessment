using System;
using System.IO;
using System.Net;
using System.Web;

namespace GeneralKnowledge.Test.App.Tests
{
    /// <summary>
    /// Image rescaling
    /// </summary>
    public class RescaleImageTest : ITest
    {
        public void Run()
        {
            // TODO
            // Grab an image from a public URL and write a function that rescales the image to a desired format
            // The use of 3rd party plugins is permitted
            // For example: 100x80 (thumbnail) and 1200x1600 (preview)

            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData("http://www.google.cn/intl/en-us/images/logo_cn.gif");
            MemoryStream ms = new MemoryStream(data);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            GetThumbnailImage(img);//Resize Image
        }

        private void GetThumbnailImage(System.Drawing.Image img)
        {
            float iScale = img.Height > img.Width ? (float)img.Height / 100 : (float)img.Width / 100;
            img = img.GetThumbnailImage((int)(img.Width / iScale), (int)(img.Height / iScale), null, IntPtr.Zero);
            MemoryStream memStream = new MemoryStream();
            img.Save(HttpContext.Current.Server.MapPath("att.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            memStream.Flush();
        }

    }
}
