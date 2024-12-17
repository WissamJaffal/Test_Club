using NUnit.Framework;
using _2024_POO1_Grafico; // Substitua pelo namespace do seu projeto principal
using System;

namespace PaisesTests
{
    public class PaisesValidationTests
    {
        [Test]
        public void TestPais_ValidInput_ShouldPass()
        {
            var pais = new Paises();
            Assert.DoesNotThrow(() => pais.Pais = "Brasil");
        }

        [Test]
        public void TestPais_EmptyInput_ShouldThrowArgumentException()
        {
            var pais = new Paises();
            var ex = Assert.Throws<ArgumentException>(() => pais.Pais = "");
            Assert.That(ex.Message, Is.EqualTo("O nome do país não pode ser vazio."));
        }

        [Test]
        public void TestSigla_ValidInput_ShouldPass()
        {
            var pais = new Paises();
            Assert.DoesNotThrow(() => pais.Sigla = "BR");
        }

        [Test]
        public void TestSigla_InvalidLength_ShouldThrowArgumentException()
        {
            var pais = new Paises();
            var ex = Assert.Throws<ArgumentException>(() => pais.Sigla = "BRA");
            Assert.That(ex.Message, Is.EqualTo("A sigla deve ter exatamente 2 caracteres."));
        }

        [Test]
        public void TestDdi_ValidInput_ShouldPass()
        {
            var pais = new Paises();
            Assert.DoesNotThrow(() => pais.Ddi = "55");
        }

        [Test]
        public void TestDdi_InvalidInput_ShouldThrowArgumentException()
        {
            var pais = new Paises();
            var ex = Assert.Throws<ArgumentException>(() => pais.Ddi = "ABC");
            Assert.That(ex.Message, Is.EqualTo("O DDI deve ser numérico e ter no máximo 5 dígitos."));
        }

        [Test]
        public void TestMoeda_ValidInput_ShouldPass()
        {
            var pais = new Paises();
            Assert.DoesNotThrow(() => pais.Moeda = "Real");
        }

        [Test]
        public void TestMoeda_EmptyInput_ShouldThrowArgumentException()
        {
            var pais = new Paises();
            var ex = Assert.Throws<ArgumentException>(() => pais.Moeda = "");
            Assert.That(ex.Message, Is.EqualTo("A moeda não pode ser vazia."));
        }
    }
}
