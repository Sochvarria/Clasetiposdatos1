namespace Clasetiposdatos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operaciones básicas
            Console.WriteLine("hola mundo");
            Console.WriteLine("suma: " + (4 + 5));
            Console.WriteLine("division: " + (10 / 5));
            Console.WriteLine("resta: " + (20 - 12));
            Console.WriteLine("multiplicacion: " + (5 * 3));

            // Variables de texto y números
            int num1 = 0, num2 = 3;
            float flotante = 3.14f;
            double doble = 3.1415;
            decimal decimal1 = 3.141592m;
            string cadena = "Hola mundo";
            string nombre = "Alexander";
            string apellido = "Benjamin";
            int edad, contador, parametros;
            bool boleano = true;
            const int iva = 13; // Valor fijo
            char caracter = 'A';

            // Tipado var y dynamic
            var variable = true; // Tipo fijo (bool)
            // variable = 20; // Error

            dynamic dinamico = 20; // Tipo cambiante
            dinamico = "Hola mundo";
            dinamico = 3.14f;
            dinamico = true;
            dinamico = 'A';

            // Impresión y formatos
            Console.WriteLine(num1);
            Console.WriteLine(dinamico);
            Console.WriteLine("La suma es:" + (num1 + num2)); // Concatenación
            Console.WriteLine($"La suma de {num1} + {num2} es {num1 + num2}"); // Interpolación
            Console.WriteLine("La suma de {0} + {1} es {2}", num1, num2, num1 + num2); // Formato con índices

            Console.WriteLine("Digite su nombre");
            nombre = Console.ReadLine();
            /*
                    Console.WriteLine("Digite su edad");
                    edad = int.Parse(Console.ReadLine()); // ==> "20" => 20
            //      flotante = float.Parse(Console.ReadLine()); // ==> "3.14" => 3.14f
            //      decimal1 = decimal.Parse(Console.ReadLine()); // ==> "3.14159265359" => 3.14159265359m

            //  int.TryParse(Console.ReadLine(), out edad); // ==> "20" => 20
            //  edad = Convert.ToInt32(Console.ReadLine()); // ==> "20" => 20

                Console.WriteLine($"Su nombre es {nombre} y su edad es {edad}");

            */

            /////////////// if con else ///////////////////////////////
            if (num1 > num2)  // true or un false
            {
                Console.WriteLine($"El número {num1}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"El número {num2}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los números son iguales");
            }

            /////////////// if sin else ///////////////////////////////

            if (num1 > num2)  // true or un false
            {
                Console.WriteLine($"El número {num1}");
            }

            if (num1 < num2)
            {
                Console.WriteLine($"El número {num2}");
            }

            if (num1 == num2)
            {
                Console.WriteLine("Los números son iguales");
            }


            Console.WriteLine("Digite el dia");

            switch (int.TryParse(Console.ReadLine(), out int dia) ? dia : 0)
            {
                case 1: Console.WriteLine("el dia lunes"); break;
                case 2: Console.WriteLine("el dia martes"); break;
                case 3: Console.WriteLine("el dia miercoles"); break;
                case 4: Console.WriteLine("el dia jueves"); break;

                default:
                    Console.WriteLine("el dia no es valido");
                    break;
            }


        }
    }
}