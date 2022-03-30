using System;

namespace Validation
{

    public class Validator
    {
        public static bool SinNumeros(string word)
        {
            if (word.IndexOf("0") != -1 || word.IndexOf("1") != -1 || word.IndexOf("2") != -1 || word.IndexOf("3") != -1 || word.IndexOf("4") != -1 || word.IndexOf("5") != -1 || word.IndexOf("6") != -1 || word.IndexOf("7") != -1 || word.IndexOf("8") != -1 || word.IndexOf("9") != -1)
                    return false;
            else
                return true;
        }

        public static bool EsValido(string email)
        {
            bool valido = false;

            if (email.IndexOf("@") != -1 && email.IndexOf("@") != 0 && email.IndexOf("@") != email.Length - 1)
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

        public static bool EsUnico(int id)
            {
                bool idUnico = true;

                while (idUnico) {
                //fix, debería recorrer todos los ID
                for (int i=0; i<10; i++) 
                {
                    if (id == 1) {
                        idUnico=false;
                        break;
                    }
                }
                }

                return idUnico;
            }
    }
}
