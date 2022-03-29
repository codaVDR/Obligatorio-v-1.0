using System;

namespace Validador
{
    class Program
    {
        static void Main(string[] args)
        {
            public bool SinNumeros(string word)
            {
                if (word.Contains(int)
                    return false;
                else
                    return true;
            }

            public bool EsValido(string email)
            { 
                bool valido=false;

               if (email.IndexOf("@") !== -1 && email.IndexOf("@") !== 0 && email.IndexOf("@") !== email.Length-1)
               {
                    valido=true;
               }

                return valido;
            }

            public bool EsSegura(string password)
            {
                bool segura = false;

                if (password.Length >= 6) { 
                for (int i=0; i< password.Length; i++)
                {
                    if (char.IsUpper(password[i]) || char.IsLower(password[i]) 
                    {
                        segura=true;
                    } else
                    {
                        segura=false;
                    }
                }
                } else
                {
                    segura=false;
                }

                return segura;
            }

            public bool EsAlfanumerico(string password) 
            {
                bool valido = false; 

                for (int i=0; i< password.Length; i++)
                {
                    // Retorna un bool si el caracter es letra o es número
                    if (char.IsLetter(password[i]) ||   char.IsNumber(password[i]) 
                    {
                        valido=true;
                    } else
                    {
                        valido=false;
                        ///break to end? 
                    }
                }    

                return valido;
            }

            public bool EsUnico (int id, class clase)
            {
                bool idUnico=true;

                while (idUnico) {
                for (int i=0; i< clase.Length; i++) 
                {
                    if (id === clase.id) {
                        idUnico=false;
                        break;
                    }
                }
                }
                return idUnico;
            }
    }
}
