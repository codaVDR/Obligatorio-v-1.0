using System;

namespace Validation
{
    public class Validator
    {
        public static bool SinNumeros(string word)
        {
            char[] palabra = word.ToCharArray();
            bool ok = false; 

            foreach (var item in palabra)
            {
                if (char.IsNumber(item))
                    ok= false;
                else
                    ok=true;
            }

            return ok;

        }

        public static bool EsValido(string email)
        {
            bool valido = false;

            if (email.IndexOf("@") != -1 && email.IndexOf("@") != 0 && email.IndexOf("@") != email.Length - 1 && email.Contains("."))
            {
                valido = true;
            }

            return valido;
        }
        public static bool EsSegura(string password)
        {
            bool segura = false;

            if (password.Length >= 6)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]) || char.IsLower(password[i]))
                    {
                        segura = true;
                    }
                    else
                    {
                        segura = false;
                    }
                }
            }
            else
            {
                segura = false;
            }

            return segura;
        }

        public static bool EsAlfanumerico(string password)
        {
            bool valido = false;

            for (int i = 0; i < password.Length; i++)
            {
                // Retorna un bool si el caracter es letra o es número
                if (char.IsLetter(password[i]) || char.IsNumber(password[i]))
                    {
                    valido = true;
                }
                else
                {
                    valido = false;
                    break;
                }
            }

            return valido;
        }

    }
}
