using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChalkovaE.M.Sprint6.Task5.V6.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ekaterinachalkova\source\repos\Tyuiu.ChalkovaE.M.Sprint6\Tyuiu.ChalkovaE.M.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
