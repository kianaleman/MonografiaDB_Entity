using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_MonografiaDB.Utilidades
{
    public class Utilities
    {
        public static int ValidarTextBox(string text)
        {
            //  1 error, 0 valido
            //  Si el textbox es vacio devuelve 1
            if (string.IsNullOrEmpty(text))
            {
                return 1;
            }
            //  Expresion regular que permite solo letras (mayusculas y minusculas) y espacios
            //  Si contiene caracteres distintos a letras devuelve 2
            else if (!System.Text.RegularExpressions.Regex.IsMatch(text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]*$"))
            {
                // Si se ingresan caracteres no volidos, muestra un mensaje de error
                return 2;
            }
            else
            {
                // Si la validacion es correcta, devuelve 0
                return 0;
            }
        }

        public static int ValidarTextBoxNumerico(string text)
        {
            // 1. Validacion de vacio
            if (string.IsNullOrWhiteSpace(text))
            {
                return 1;
            }

            // 2. Expresion regular para permitir solo numeros y un punto decimal
            // La expresion regular valida:
            // - Solo digitos (`\d`)
            // - Un unico punto decimal
            // - Al menos un numero antes o despues del punto
            else if (!System.Text.RegularExpressions.Regex.IsMatch(text, @"^\d+(\.\d+)?$"))
            {
                // Si contiene caracteres no validos
                return 2;
            }

            // 3. Texto valido
            return 0;
        }
    }
}
