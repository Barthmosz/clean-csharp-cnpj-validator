using System.Text.RegularExpressions;

namespace Clean.CnpjValidator
{
    public static class CnpjValidator
    {
        public static bool Validate(string cnpj)
        {
            string cnpjRegex = "^\\d{2}\\.\\d{3}\\.\\d{3}\\/\\d{4}-\\d{2}$";
            return Regex.IsMatch(cnpj, cnpjRegex);
        }
    }
}
