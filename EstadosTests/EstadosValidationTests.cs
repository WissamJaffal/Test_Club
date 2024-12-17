using NUnit.Framework;
using _2024_POO1_Grafico; // Substitua pelo namespace do seu projeto principal
using System;

namespace EstadosTests
{
    public class EstadosValidationTests
    {
        [Test]
        public void TestEstado_ValidInput_ShouldPass()
        {
            var estado = new Estados();
            Assert.DoesNotThrow(() => estado.Estado = "Paraná");
        }

        [Test]
        public void TestEstado_EmptyInput_ShouldThrowArgumentException()
        {
            var estado = new Estados();
            var ex = Assert.Throws<ArgumentException>(() => estado.Estado = "");
            Assert.That(ex.Message, Is.EqualTo("O nome do estado não pode ser vazio."));
        }

        [Test]
        public void TestUf_ValidInput_ShouldPass()
        {
            var estado = new Estados();
            Assert.DoesNotThrow(() => estado.Uf = "PR");
        }

        [Test]
        public void TestUf_InvalidLength_ShouldThrowArgumentException()
        {
            var estado = new Estados();
            var ex = Assert.Throws<ArgumentException>(() => estado.Uf = "PAR");
            Assert.That(ex.Message, Is.EqualTo("A UF deve ter exatamente 2 caracteres."));
        }

        [Test]
        public void TestOPais_ValidInput_ShouldPass()
        {
            var estado = new Estados();
            var pais = new Paises { Codigo = 1, Pais = "Brasil" };
            Assert.DoesNotThrow(() => estado.OPais = pais);
        }

        [Test]
        public void TestOPais_NullInput_ShouldThrowArgumentException()
        {
            var estado = new Estados();
            var ex = Assert.Throws<ArgumentException>(() => estado.OPais = null);
            Assert.That(ex.Message, Is.EqualTo("O país não pode ser nulo."));
        }
    }
}
