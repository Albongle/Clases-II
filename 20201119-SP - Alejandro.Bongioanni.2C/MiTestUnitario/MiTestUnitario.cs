using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace MiTestUnitario
{
    [TestClass]
    public class MiTestUnitario
    {
        [TestMethod]
        public void ProbarInstancia() // Pruebo la instacia ya que no pude probar serializar, pero si veo que me guarda el archivo, hay alguno problema que no logor decifrar
        {
            Bombero bombero = new Bombero("Jose");
            Assert.IsNotNull(bombero);
        }
        [TestMethod]
        public void PruebaSerializacion()
        {

            Bombero bombero = new Bombero("Jose");
            Bombero bombero1;
            bombero.Guardar(bombero);
            bombero1 = bombero.Leer();

            Assert.IsTrue(bombero.Nombre == bombero1.Nombre);

        }

    }
}
