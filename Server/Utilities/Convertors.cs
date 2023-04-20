using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Server.Utilities
{
    public static class Convertors
    {
        public static byte[] DecodeUrlBase64(string s)
        {
            return Convert.FromBase64String(s.Substring(s.LastIndexOf(',') + 1));
        }

        public static Image Base64ToImage(string base64String)
        {
            var res = DecodeUrlBase64(base64String);
            MemoryStream ms = new MemoryStream(res, 0, res.Length);
            ms.Write(res, 0, res.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
    public static class ImageUploader
    {
        public static void AddImageToServer(this Image image, string fileName, string originalPath, string deleteFileName = null)
        {

            if (image != null)
            {
                if (!Directory.Exists(originalPath))
                    Directory.CreateDirectory(originalPath);

                if (!string.IsNullOrEmpty(deleteFileName))
                {
                    if (File.Exists(originalPath + deleteFileName))
                        File.Delete(originalPath + deleteFileName);
                }

                string OriginPath = originalPath + fileName;

                using (var stream = new FileStream(OriginPath, FileMode.Create))
                {
                    if (!Directory.Exists(OriginPath)) image.Save(stream, ImageFormat.Jpeg);
                }
            }
        }
    }
    public static class PathTools
    {
        public static readonly string PeopleImageAddress = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/People/");
        public static readonly string MoviePosterAddress = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/Article/");
        public static readonly string PeopleShowImageAddress = "/Images/People/";
        public static readonly string MoviePosterShowAddress = "/Images/Article/";


    }

}
