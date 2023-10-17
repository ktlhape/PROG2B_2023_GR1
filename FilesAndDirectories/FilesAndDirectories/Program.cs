using System.IO;
namespace FilesAndDirectories
{
    internal class Program
    {
        static string strPath = @"C:\Users\kaykt\Documents\XYZ";
        static void Main(string[] args)
        {

            //CreateDirectory();
            //DriveData();
            // CreateFiles();
            WriteToFile();


        }

        static void CreateDirectory()
        {
            //Get directory info
            DirectoryInfo dirDocuments = new DirectoryInfo(@"C:\Users\kaykt\Documents");
            DisplayInfo(dirDocuments);

            Console.WriteLine("==============================");
            //Create a directory
            DirectoryInfo dir1 = new DirectoryInfo(strPath);


            if (dir1.Exists)
            {
                DisplayInfo(dir1);
            }
            else
            {
                dir1.Create();
                DisplayInfo(dir1);
            }

            
            

        }

        static void DriveData()
        {
            Console.WriteLine("=====Drive Data=====");
            DriveInfo[] myDrives = DriveInfo.GetDrives();



            foreach (DriveInfo dr in myDrives)
            {
                if (dr.IsReady)
                {
                    Console.WriteLine(dr.Name);
                    Console.WriteLine(dr.VolumeLabel);
                    Console.WriteLine(dr.TotalSize);
                    Console.WriteLine(dr.DriveType);
                    Console.WriteLine(dr.AvailableFreeSpace);
                    Console.WriteLine("----------------------------");
                }
             

            }
        }

        static void CreateFiles()
        {
            FileInfo f = new FileInfo(strPath + @"\Test.txt");

            if (f.Exists)
            {
                //
            }
            else
            {
                f.Create();

                //

            }


        }

        static void WriteToFile()
        {
            string[] arHobbies = { "Tennis", "Hockey", "Soccer", "Swimming" };
            FileInfo f = new FileInfo(strPath + @"\Test.txt");
            if (f.Exists)
            {
                using (StreamWriter pen = f.AppendText())
                {
                    for (int i = 0; i < arHobbies.Length; i++)
                    {
                        pen.WriteLine($"{i + 1}. {arHobbies[i]}");
                    }
                }
            }
            else
            {
                using (StreamWriter pen = f.CreateText())
                {
                    pen.WriteLine("This is just a test");
                }
            }
         
            


        }
        static void DisplayInfo(DirectoryInfo dir)
        {
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.Attributes);
            
        }

    }
}