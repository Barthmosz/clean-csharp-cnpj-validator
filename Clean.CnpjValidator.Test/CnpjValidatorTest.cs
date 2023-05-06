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
    }
}
