using Core.Utilites.Helper.GUIDHelper;
using Microsoft.AspNetCore.Http;

namespace Core.Utilites.Helper.FileHelper;

public class FileHelperManager : IFileHelper
{
    public void Delete(string filePath)
    {
        if (File.Exists(filePath)) File.Delete(filePath);
    }

    public string Update(IFormFile formFile, string root, string filePath)
    {
        if (File.Exists(filePath)) File.Delete(filePath);
        return Upload(formFile, root);
    }

    public string Upload(IFormFile formFile, string root)
    {
        if (formFile.Length > 0)
        {
            if (!Directory.Exists(root)) Directory.CreateDirectory(root);
            var extension = Path.GetExtension(formFile.FileName);
            var guid = GuidHelper.CreateGuid();
            var filePath = guid + extension;
            using (var fs = File.Create(root + filePath))
            {
                formFile.CopyTo(fs);
                fs.Flush();
                return filePath;
            }
        }

        return null;
    }
}