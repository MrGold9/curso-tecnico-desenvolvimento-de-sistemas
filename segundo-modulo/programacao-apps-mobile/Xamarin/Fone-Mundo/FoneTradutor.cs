using System.Text;
using System;
namespace Core

{
    public static class TraduzindoFoneMundo
    {
        public static string ONumero(string x)
        {
            if (string.IsNullOrWhiteSpace(x))
                return "";
            else
            {
                x = x.ToUpperInvariant();
                var novoNumero = new StringBuilder();
                foreach (var c in x)
                {
                    if (" -0123456789".Contains(c))
                    {
                        novoNumero.Append(c);
                    }
                    else
                    {
                        var resultado = TraduziroNumero(c);
                        if (resultado != null)
                            novoNumero.Append(resultado);
                    }
                }
                return novoNumero.ToString();
            }
        }
        static bool Contains(this string keyString, char c)
        {
            return keyString.IndexOf(c) >= 0;
        }
        static int? TraduziroNumero(char c)
        {
            if ("ABC".Contains(c))
                return 2;
            else if ("DEF".Contains(c))
                return 3;
            else if ("GHI".Contains(c))
                return 4;
            else if ("JKL".Contains(c))
                return 5;
            else if ("MNO".Contains(c))
                return 6;
            else if ("PQRS".Contains(c))
                return 7;
            else if ("TUV".Contains(c))
                return 8;
            else if ("WXYZ".Contains(c))
                return 9;
            return null;
        }
    }
}