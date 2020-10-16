using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System.Collections.Generic;

namespace MiTestUnitario
{
    [TestClass]
    public class UnitTestCentralita
    {
        [TestMethod]
        public void ValidaListaDeLlamadas()
        {
            //Arrange
            Centralita nuevaCentralita = new Centralita();
            //Act
            //Assert
            Assert.IsNotNull(nuevaCentralita.Llamadas);          
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void ValidaExcepcionLocal()
        {
            //Arrange
            Centralita nuevaCentralita = new Centralita();
            Local llamada = new Local("Bernal", 30, "Rosario", 2.65f);
            //Act
            nuevaCentralita += llamada;
            nuevaCentralita += llamada;
            //Assert            
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void ValidaExcepcionProvincial()
        {
            //Arrange
            Centralita nuevaCentralita = new Centralita();
            Provincial llamada = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial llamadaDos = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            //Act
            nuevaCentralita += llamada;
            nuevaCentralita += llamadaDos;
            //Assert            
        }
        [TestMethod]
        public void ValidaTipoDeLlamado()
        {
            //Arrange
            Local llamadaLocal1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local llamadaLocal2 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial llamadaProv1 = new Provincial("Bernal", Provincial.Franja.Franja_1, 21, "Rosario");
            Provincial llamadaProv2 = new Provincial("Bernal", Provincial.Franja.Franja_1, 21, "Rosario");
            //Act
            //Assert
            Assert.AreEqual(llamadaLocal1, llamadaLocal2);
            Assert.AreNotEqual(llamadaLocal1, llamadaProv1);
            Assert.AreNotEqual(llamadaLocal1, llamadaProv2);
            Assert.AreEqual(llamadaProv1, llamadaProv2);
            Assert.AreNotEqual(llamadaLocal2, llamadaProv1);
            Assert.AreNotEqual(llamadaLocal2, llamadaProv2);
        }
    }
}

