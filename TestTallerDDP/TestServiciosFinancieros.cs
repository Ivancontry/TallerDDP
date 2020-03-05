using NUnit.Framework;
using TallerDDP;

namespace TestTallerDDP
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValorConsignaciónNegativoCero() {

            ServiciosFinancieros serviciosFinancieros = new ServiciosFinancieros(new CuentaAhorro("Ivan contreras","0001",0,"Valledupar"));
            Consignacion consignacion = new Consignacion("Valledupar",-5000);
            var respuesta =serviciosFinancieros.Consignacion(consignacion);        
            Assert.AreEqual("El valor a consignar es incorrecto", respuesta);
        }

        [Test]
        public void ConsignacionInicialCorrecta() {

            CuentaAhorro cuentaAhorro = new CuentaAhorro("Cuenta ejemplo", "0001", 0, "Valledupar");
            cuentaAhorro.setPrimeraConsignacion(true);
            ServiciosFinancieros serviciosFinancieros = new ServiciosFinancieros(cuentaAhorro);
            Consignacion consignacion = new Consignacion("Valledupar", 50000);
            var respuesta = serviciosFinancieros.Consignacion(consignacion);

            Assert.AreEqual("Su nuevo saldo es " + 50000 + " m/c", respuesta);

        }

        [Test]

        public void ConsignacionInicialIncorrecta() {
            CuentaAhorro cuentaAhorro = new CuentaAhorro("Cuenta ejemplo", "0001", 0, "Valledupar");
            cuentaAhorro.setPrimeraConsignacion(true);
            ServiciosFinancieros serviciosFinancieros = new ServiciosFinancieros(cuentaAhorro);
            Consignacion consignacion = new Consignacion("Valledupar", 40000);
            var respuesta = serviciosFinancieros.Consignacion(consignacion);

            Assert.AreEqual("El valor mínimo de la primera consignación debe ser de $50.000 mil pesos. Su nuevo saldo es $0 pesos", respuesta);
        }

        [Test]

        public void ConsignacionPosteriorInicialCorrecta()
        {
            ServiciosFinancieros serviciosFinancieros = new ServiciosFinancieros(new CuentaAhorro("Cuenta ejemplo", "0001", 30000, "Valledupar"));
            Consignacion consignacion = new Consignacion("Valledupar", 49950);
            var respuesta = serviciosFinancieros.Consignacion(consignacion);
            Assert.AreEqual("Su nuevo saldo es " + 79950 + " m/c", respuesta);
        }

        [Test]

        public void ConsignacionPosteriorInicialCorrectaCiudad()
        {
            ServiciosFinancieros serviciosFinancieros = new ServiciosFinancieros(new CuentaAhorro("Cuenta ejemplo", "0001", 30000, "Bogota"));
            Consignacion consignacion = new Consignacion("Valledupar", 49950);
            var respuesta = serviciosFinancieros.Consignacion(consignacion);
            Assert.AreEqual("Su nuevo saldo es " + 69950 + " m/c", respuesta);
        }
    }
}

