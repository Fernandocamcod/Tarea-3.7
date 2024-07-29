using System;

class ProgramaVotacion
{
    static void Main()
    {
        Console.WriteLine("Ingrese su edad:");
        int edad;

        // Intentar leer la edad ingresada y manejar posibles errores
        if (int.TryParse(Console.ReadLine(), out edad))
        {
            // Variable para almacenar el mensaje de resultado
            string mensaje;

            // Determinar si el usuario puede votar
            switch (edad)
            {
                case int n when (n >= 18):
                    mensaje = "Usted puede votar.";
                    break;
                case int n when (n < 18 && n >= 0):
                    mensaje = "Usted no puede votar.";
                    break;
                default:
                    mensaje = "Edad no válida. Por favor, ingrese una edad positiva.";
                    break;
            }

            // Mostrar el resultado
            Console.WriteLine(mensaje);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero para la edad.");
        }

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
