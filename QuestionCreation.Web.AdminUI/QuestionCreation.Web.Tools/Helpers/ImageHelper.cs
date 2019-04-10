using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace QuestionCreation.Web.Tools.Helpers
{
    public static class ImageHelper
    {
        private const int ImageMinimumBytes = 512;

        public static List<string> UploadImages(IEnumerable<HttpPostedFileBase> files)
        {
            List<string> names = new List<string>();

            foreach (HttpPostedFileBase file in files)
            {
                names.Add(UploadImage(file));
            }

            return names;
        }


        public static string FileUpload(HttpPostedFileBase file, string domainName = null, bool resize = true)
        {
            string name = string.Empty;
            if (file != null)
            {
                string imagePath = HttpContext.Current.Server.MapPath(SystemParameters.SystemParameters.GetImagePath(HttpContext.Current.Request.Url.Authority));

                if (domainName != null)
                {
                    imagePath = HttpContext.Current.Server.MapPath("/content/upload/" + domainName + "/");
                }
                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }
                name = resize ? Path.GetFileName(file.FileName) : GenerateFileName(file.FileName);
                if (name != null)
                {
                    string path = Path.Combine(imagePath, name);
                    // file is uploaded
                    file.SaveAs(path);

                    if (resize)
                    {
                        using (var image = Image.FromFile(path))
                        {
                            name = GenerateFileName(file.FileName);
                            for (int i = 0; i <= 2; i++)
                            {
                                string folder;
                                using (var newImage = ScaleImage(image, i, out folder))
                                {
                                    Directory.CreateDirectory(Path.Combine(imagePath, folder));
                                    string newPath = Path.Combine(imagePath, folder, name);
                                    newImage.Save(newPath, ImageFormat.Png);
                                }
                            }
                        }

                        File.Delete(path);
                    }
                }
            }

            return name;
        }
        public static string FileCssUpload(HttpPostedFileBase file, bool resize = true)
        {
            string name = string.Empty;
            if (file != null)
            {
                string mapPath = HttpContext.Current.Server.MapPath("/content/upload/assets");
                if (!Directory.Exists(mapPath))
                {
                    Directory.CreateDirectory(mapPath);
                }
                name = resize ? Path.GetFileName(file.FileName) : GenerateFileName(file.FileName);
                if (name != null)
                {
                    string path = Path.Combine(mapPath, name);
                    // file is uploaded
                    file.SaveAs(path);
                }
            }

            return name;
        }

        public static Image ScaleImage(Image image, int i, out string folder)
        {
            int maxHeight;
            switch (i)
            {
                case 0:
                    maxHeight = 192;
                    folder = "small";
                    break;
                case 1:
                    maxHeight = 720;
                    folder = "large";
                    break;
                default:
                    maxHeight = 480;
                    folder = "medium";
                    break;

            }

            int maxWidth = maxHeight * 16 / 9;

            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);


                return newImage;
            }
        }

        public static string UploadImage(HttpPostedFileBase file, string domainName = null, bool resize = true)
        {
            if (file.IsImage())
                return FileUpload(file, domainName, resize);
            return null;
        }

        public static string UploadCss(HttpPostedFileBase file, bool resize = true)
        {
            return FileCssUpload(file, resize);
        }



        public static bool DeleteImage(string name)
        {
            string imagePath = Path.Combine(HttpContext.Current.Server.MapPath(SystemParameters.SystemParameters.GetImagePath(HttpContext.Current.Request.Url.Authority)), name);

            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
                return true;
            }

            return false;
        }

        public static string RotateImage(string fileName, int degree)
        {
            RotateFlipType rotateFlipType = RotateFlipType.RotateNoneFlipNone;
            switch (degree)
            {
                case 90:
                    rotateFlipType = RotateFlipType.Rotate90FlipNone;
                    break;
                case 180:
                    rotateFlipType = RotateFlipType.Rotate180FlipNone;
                    break;
                case 270:
                    rotateFlipType = RotateFlipType.Rotate270FlipNone;
                    break;
            }
            fileName = fileName.Split('/').Last();
            //string uploadedImagePath = ""; // _appSettings.uploadedImagePath;
            var upload = HttpContext.Current.Server.MapPath(SystemParameters.SystemParameters.GetImagePath(HttpContext.Current.Request.Url.Authority));
            if (!Directory.Exists(upload))
            {
                Directory.CreateDirectory(upload);
            }
            string input = Path.Combine(upload + "/large", fileName);
            fileName = GenerateFileName(fileName);

            //create an object that we can use to examine an image file
            using (Image img = Image.FromFile(input))
            {
                img.RotateFlip(rotateFlipType);

                for (int i = 0; i < 3; i++)
                {
                    string folder;
                    using (var newImage = ScaleImage(img, i, out folder))
                    {
                        //System.IO.Directory.CreateDirectory(Path.Combine(imagePath, folder));
                        //string newPath = System.IO.Path.Combine(
                        //                  imagePath, folder, name);
                        newImage.Save(upload + "/" + folder + "/" + fileName, ImageFormat.Jpeg);
                    }
                }


            }

            return fileName;
        }

        private static string GenerateFileName(string fileName)
        {
            return Guid.NewGuid() + Path.GetExtension(fileName);
        }

        public static bool IsImage(this HttpPostedFileBase postedFile)
        {
            //-------------------------------------------
            //  Check the image mime types
            //-------------------------------------------
            if (postedFile.ContentType.ToLower() != "image/jpg" &&
                        postedFile.ContentType.ToLower() != "image/jpeg" &&
                        postedFile.ContentType.ToLower() != "image/pjpeg" &&
                        postedFile.ContentType.ToLower() != "image/gif" &&
                        postedFile.ContentType.ToLower() != "image/x-png" &&
                        postedFile.ContentType.ToLower() != "image/png")
            {
                return false;
            }

            //-------------------------------------------
            //  Check the image extension
            //-------------------------------------------
            var extension = Path.GetExtension(postedFile.FileName);
            if (extension != null && (extension.ToLower() != ".jpg"
                && extension.ToLower() != ".png"
                && extension.ToLower() != ".gif"
                && extension.ToLower() != ".jpeg"))
            {
                return false;
            }

            //-------------------------------------------
            //  Attempt to read the file and check the first bytes
            //-------------------------------------------
            try
            {
                if (!postedFile.InputStream.CanRead)
                {
                    return false;
                }

                if (postedFile.ContentLength < ImageMinimumBytes)
                {
                    return false;
                }

                byte[] buffer = new byte[512];
                postedFile.InputStream.Read(buffer, 0, 512);
                string content = System.Text.Encoding.UTF8.GetString(buffer);
                if (Regex.IsMatch(content, @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy",
                            RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline) || content.StartsWith("MZ") || content.StartsWith("ZM"))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            //-------------------------------------------
            //  Try to instantiate new Bitmap, if .NET will throw exception
            //  we can assume that it's not a valid image
            //-------------------------------------------

            try
            {
                using (new Bitmap(postedFile.InputStream))
                {
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                postedFile.InputStream.Position = 0;
            }

            return true;
        }
    }
}
