using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyankovaVV.Sprint6.Review.V18.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Review.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] array = new int[,]
            {
                { 1, 2, 3, 4, -5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };
            int R = 2;
            int k = 0;
            int l = 3;
            int res = DataService.GetMatrix(array, R, k, l);

            int wait = 26;

            Assert.AreEqual(wait, res);
        }
    }
}
