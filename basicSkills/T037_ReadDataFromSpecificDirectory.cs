/*
Description:
    Aim: teach people how to read data from specific directory.
 */
using System;
using System.IO;    // this package is necessary

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // info will store the full directory we give
            DirectoryInfo info = new DirectoryInfo(@"C:\documents\C#Project\Pro_W\researchData\downloadFile\releasedFile\");
            // Exists method will get a bool value, if directory exits, True. Attention, judge directory not file.
            Console.WriteLine(info.Exists);
            #endregion
            
            #region
            DirectoryInfo info = new DirectoryInfo(@"C:\Users\15025\Desktop\C#Debug");
            // if directory not exists, create it
            if (! info.Exists)
            {
                info.Create();
            }
            // if directory exists, delete it, the director must be empty
            if (info.Exists)
            {
                info.Delete();
            }
        }
    }
}
