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
            return email.IndexOf("@") != -1 && email.IndexOf("@") != 0 && email.IndexOf("@") != email.Length - 1 && email.Contains(".");
        }

        public static bool TieneLetrasMayus(string password)
        {
            char[] passw = password.ToCharArray();
            string mayusculas = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            bool validoMayusculas = false;


            foreach (var item in passw)
            {
                if (mayusculas.IndexOf(item) != -1)
                {
                    validoMayusculas = true;
                }
            }

            return validoMayusculas;
        }

        public static bool TieneLetrasMinus(string password)
        {
            char[] passw = password.ToCharArray();
            string minusculas = "abcdefghijklmnñopqrstuvwxyz";
            bool validoMinusculas = false;

            foreach (var item in passw)
            {
                if (minusculas.IndexOf(item) != -1)
                {
                    validoMinusculas = true;
                }
            }

            return validoMinusculas;
        }
        public static bool TieneNumeros(string password)
        {
            char[] passw = password.ToCharArray();
            string numeros = "0123456789";
            bool validoNumeros = false;

            foreach (var item in passw)
            {
                if (numeros.IndexOf(item) != -1)
                {
                    validoNumeros = true;
                }
            }

            return validoNumeros;
        }


        public static bool EsSegura(string password)
        {
            return password.Length >= 6 && TieneNumeros(password) && TieneLetrasMinus(password) && TieneLetrasMayus(password);
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

        public static bool EsTexto(string texto)
        {
            bool valido = false;

            for (int i = 0; i < texto.Length; i++)
            {

                if (char.IsLetter(texto[i]))
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
