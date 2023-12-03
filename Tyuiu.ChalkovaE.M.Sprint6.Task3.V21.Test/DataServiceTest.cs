using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint6.Task3.V21.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[,] { { 26, -15, 7, 1, 4 }, { 14, 26, 22, 17, 27 }, 
                { -8, 31, 22, 34, 4 }, { -18, 16, -2, 16, 27 }, { 5, 2, -4, 16, 15 } };
            int[,] wait = new int[,] { { -18, -15, 7, 1, 4 }, { -8, 26, 22, 17, 27 },
                { 5, 31, 22, 34, 4 }, { 14, 16, -2, 16, 27 }, { 26, 2, -4, 16, 15 } };
            int[,] res = ds.Calculate(mtrx);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
