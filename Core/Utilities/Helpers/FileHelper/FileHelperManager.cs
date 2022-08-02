using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
  
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return Upload(file, root);
        }


        public string Upload(IFormFile file, string root)
        {
            if (file!=null)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid().ToString() + imageExtension;

                using (FileStream fileStream = File.Create(root + imageName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return imageName;

                }
            }
            return null;
        }
    }
}
