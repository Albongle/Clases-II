using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace MiTestUnitario
{
    [TestClass]
    public class MiTestUnitario
    {
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestMetodoInstancia()
        {
            //Arrange
            OtraClase otra = new OtraClase();
            //Act
            otra.MetodoInstancia();
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMetodoStatico()
        {
            //Arrange
            //Act
            MiClase.MiMetodoEstatico();
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestConstructorMiClaseConParametro()
        {
            //Arrange
            MiClase miclase = new MiClase(10);
            //Act
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestConstructorMiClase()
        {
            //Arrange
            MiClase miclase = new MiClase();
            //Act
            //Assert
        }
    }
}
