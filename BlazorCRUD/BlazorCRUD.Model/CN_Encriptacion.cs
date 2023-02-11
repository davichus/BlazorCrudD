using System;
namespace BlazorCRUD.Model
{
    public static class CN_Encriptacion
    {
        /// Encripta una cadena
        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        /// Encripta una cadena
        public static int Encriptar1(this int _cadenaAencriptar)
        {
            string result = string.Empty;
            int res = Int32.Parse(result);
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar.ToString());
            result = Convert.ToBase64String(encryted);
            return res;
        }
    }
}
