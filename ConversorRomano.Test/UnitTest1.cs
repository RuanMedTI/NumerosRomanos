using ConversorRomano.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConversorRomano.Test
{
    [TestClass]
    public class UnitTest1
    {
        ConversorNumeroIndoArabico conversor = new ConversorNumeroIndoArabico();

        ConverterNumeroRomano conversor2 = new ConverterNumeroRomano();

        [TestMethod]
        public void Retornar_I()
        {
            Assert.AreEqual("I", conversor.ConversorNumeroIndoArabicoPrimario(1));
        }

        [TestMethod]
        public void Retornar_II()
        {
            Assert.AreEqual("II", conversor.ConversorNumeroIndoArabicoPrimario(2));
        }

        [TestMethod]
        public void Retornar_III()
        {
            Assert.AreEqual("III", conversor.ConversorNumeroIndoArabicoPrimario(3));
        }

        [TestMethod]
        public void Retornar_V()
        {
            Assert.AreEqual("V", conversor.ConversorNumeroIndoArabicoPrimario(5));
        }

        [TestMethod]
        public void Retornar_VI()
        {
            Assert.AreEqual("VI", conversor.ConversorNumeroIndoArabicoPrimario(6));
        }

        [TestMethod]
        public void Retornar_X()
        {
            Assert.AreEqual("X", conversor.ConversorNumeroIndoArabicoPrimario(10));
        }

        [TestMethod]
        public void Retornar_XI()
        {
            Assert.AreEqual("XI", conversor.ConversorNumeroIndoArabicoPrimario(11));
        }

        [TestMethod]
        public void Retornar_XX()
        {
            Assert.AreEqual("XX", conversor.ConversorNumeroIndoArabicoPrimario(20));
        }

        [TestMethod]
        public void Retornar_XL()
        {
            Assert.AreEqual("XL", conversor.ConversorNumeroIndoArabicoPrimario(40));
        }

        [TestMethod]
        public void Retornar_L()
        {
            Assert.AreEqual("L", conversor.ConversorNumeroIndoArabicoPrimario(50));
        }

        [TestMethod]
        public void Retornar_XC()
        {
            Assert.AreEqual("XC", conversor.ConversorNumeroIndoArabicoPrimario(90));
        }

        [TestMethod]
        public void Retornar_C()
        {
            Assert.AreEqual("C", conversor.ConversorNumeroIndoArabicoPrimario(100));
        }

        [TestMethod]
        public void Retornar_M()
        {
            Assert.AreEqual("M", conversor.ConversorNumeroIndoArabicoPrimario(1000));
        }

    }
}
