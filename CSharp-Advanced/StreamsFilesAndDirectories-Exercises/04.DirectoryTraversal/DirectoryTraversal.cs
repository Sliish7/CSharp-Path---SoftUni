namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Schema;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> fileExtension = new SortedDictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (var f in files)
            {
                FileInfo fileInfo = new FileInfo(f);

                if (!fileExtension.ContainsKey(fileInfo.Extension))
                {
                    fileExtension.Add(fileInfo.Extension, new List<FileInfo>());
                }

                fileExtension[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var fe in fileExtension.OrderByDescending(fe => fe.Value.Count))
            {
                sb.AppendLine(fe.Key);

                foreach (var file in fe.Value.OrderBy(f => f.Length))
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024:f3}kb");
                }
            }
            
            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string fPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(fPath, textContent);
        }
    }
}
