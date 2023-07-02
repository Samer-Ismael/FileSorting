using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorting
{
    internal class Sorting
    {
        private DirectoryInfo sourceFolder;
        private Dictionary<string, string> folderNames;

        public Sorting(string sourceFolderPath)
        {
            this.sourceFolder = new DirectoryInfo(sourceFolderPath);
            this.folderNames = new Dictionary<string, string>();
            InitializeFolderNames();
        }

        public void RunTheApp()
        {
            try
            {
                SortFilesByType();
                Console.WriteLine("Files sorted successfully!");
            }
            catch (IOException e)
            {
                Console.Error.WriteLine("An error occurred: " + e.Message);
            }
        }

        public void SortFilesByType()
        {
            if (!sourceFolder.Exists)
                throw new ArgumentException("Source folder does not exist.");

            FileInfo[] files = sourceFolder.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Exists)
                {
                    string fileType = GetFileType(file);

                    string folderName = GetFolderName(fileType);
                    DirectoryInfo typeDir = new DirectoryInfo(Path.Combine(sourceFolder.FullName, folderName));

                    if (!typeDir.Exists)
                        typeDir.Create();

                    string destPath = Path.Combine(typeDir.FullName, file.Name);
                    file.MoveTo(destPath);
                }
            }
        }

        private void InitializeFolderNames()
        {
            folderNames.Add("exe", "runnable");
            folderNames.Add("jpg", "images");
            folderNames.Add("txt", "text_files");
            folderNames.Add("mp3", "audio");
            folderNames.Add("pdf", "documents");
            folderNames.Add("doc", "documents");
            folderNames.Add("xls", "documents");
            folderNames.Add("ppt", "documents");
            folderNames.Add("zip", "compressed");
            folderNames.Add("rar", "compressed");
            folderNames.Add("png", "images");
            folderNames.Add("gif", "images");
            folderNames.Add("java", "source_code");
        }

        private string GetFolderName(string fileType)
        {
            string folderName;
            if (!folderNames.TryGetValue(fileType, out folderName))
                folderName = "other";

            return folderName;
        }

        private string GetFileType(FileInfo file)
        {
            string fileName = file.Name;
            int dotIndex = fileName.LastIndexOf('.');
            if (dotIndex > 0 && dotIndex < fileName.Length - 1)
            {
                return fileName.Substring(dotIndex + 1).ToLower();
            }
            return "other";
        }
    }
}
