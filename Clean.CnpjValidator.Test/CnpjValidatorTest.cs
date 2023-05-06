using NUnit.Framework;

namespace Clean.CnpjValidator.Test
{
    [TestFixture]
    public class CnpjValidatorTest
    {
        [Test, Description("ensure CnpjValidator returns false if an invalid cnpj is provided")]
        public void CnpjValidator_InvalidCnpj_ReturnsFalse()
        {
            Assert.That(CnpjValidator.Validate("12.345.678/9123"), Is.EqualTo(false));
        }

        [Test, Description("ensure CnpjValidator returns false if an empty cnpj is provided")]
        public void CnpjValidator_EmptyCnpj_ReturnsFalse()
        {
            Assert.That(CnpjValidator.Validate(""), Is.EqualTo(false));
        }

        [Test, Description("ensure CnpjValidator returns true if a valid cnpj is provided")]
        public void CnpjValidator_ValidCnpj_ReturnsTrue()
        {
            Assert.That(CnpjValidator.Validate("12.345.678/9123-45"), Is.EqualTo(true));
        }
    }
}
