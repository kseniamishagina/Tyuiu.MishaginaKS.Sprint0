using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MishaginaKS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MishaginaKS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChectGetMessegeValid()
        {
            var name = "Ксюша";
            var res = DataService.GetMessege(name);

            Assert.AreEqual("Привет..., Ксюша", res);

        }
    }
}
