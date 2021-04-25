using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoCalidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsCalidadTest
{
    [TestClass]
    public class prueba_Suma
    {
        [DataRow(4,4,8)]
        [DataRow(3,5,8)]
        [DataRow(5,5,10)]
        [DataRow(6,7,13)]

        [TestMethod]
        public void Suma_CalculayRetornaResultado(int a, int b, int esperado)
        {
            //arrage
            //int a = 5;
            //int b = 4;
            //int esperado = 9;

            //act
            int real = clsCalc.suma(a, b);

            //assert
            Assert.AreEqual(real, esperado);
        }
    }

    [TestClass]
    public class prueba_Resta
    {
        [DataRow(4, 4, 0)]
        [DataRow(5, 3, 2)]
        [DataRow(10, 6, 4)]
        [DataRow(6, 3, 3)]

        [TestMethod]
        public void Resta_CalculayRetornaResultado(int a, int b, int esperado)
        {
            //arrage
            //valores desde datarow

            //act
            int real = clsCalc.resta(a, b);

            //assert
            Assert.AreEqual(real, esperado);
        }
    }

    [TestClass]
    public class prueba_Multiplica
    {
        [DataRow(4, 4, 16)]
        [DataRow(5, 3, 15)]
        [DataRow(10, 6, 60)]
        [DataRow(6, 3, 18)]

        [TestMethod]
        public void Multiplica_CalculayRetornaResultado(int a, int b, int esperado)
        {
            //arrage
            //valores desde datarow

            //act
            int real = clsCalc.multiplica(a, b);

            //assert
            Assert.AreEqual(real, esperado);
        }
    }

    [TestClass]
    public class prueba_Division
    {
        [DataRow(4, 4, 1)]
        [DataRow(8, 2, 4)]
        [DataRow(10, 5, 2)]
        [DataRow(16, 4, 4)]

        [TestMethod]
        public void Divide_CalculayRetornaResultado(int a, int b, int esperado)
        {
            //arrage
            //valores desde datarow

            //act
            int real = clsCalc.divide(a, b);

            //assert
            Assert.AreEqual(real, esperado);
        }
    }
}
