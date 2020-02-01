using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeContactos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool PaCerrar = true;
            string[] Nombres = new string[15];
            string[] Numero = new string[15];

            while (PaCerrar)
            {
                


                
                
                int menu = 0;
                
              

                Console.Clear();

                Console.WriteLine("Bienvenido a su lista de contactos, elija la opcion deseada: \n" +
              "\n 1- Agregar a lista \n" +
              "\n 2- Lista de contactos \n" +
              "\n 3- Editar la lista \n" +
              "\n 4- Eliminar \n" +
              "\n 5- Salir\n ");

              menu=  Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Introduzca el nombre: ");

                        string name = Console.ReadLine();
                        if (string.IsNullOrEmpty(Nombres[14]))
                        {
                            Console.Clear();
                            for (int index = 0; index < Nombres.Length; index++)
                            {
                                
                                string elemento = Nombres[index];


                                if (string.IsNullOrEmpty(elemento))
                                {

                                    Nombres[index] = name;
                                    break;
                                }

                            }
                            Console.WriteLine("Introduzca el numero: ");
                            string num = Console.ReadLine();

                            for (int index = 0; index < Numero.Length; index++)
                            {
                                
                                string elemento2 = Numero[index];


                                if (string.IsNullOrEmpty(elemento2))
                                {

                                    Numero[index] = num;
                                    break;
                                }

                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No hay mas espacio.");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Lista de contactos: \n");

                        for (int index = 0; index < Nombres.Length; index++)
                        {
                            string elemento = Nombres[index];
                            string elemento2 = Numero[index];


                         Console.WriteLine((index + 1) + "-" + elemento + "              " + elemento2);
                           
                        }
                        Console.ReadKey();

                       


                        break;


                    //No toques despues de aqui xd


                    case 3:
                        Console.Clear();
                        Console.WriteLine("Introduzca el contacto a editar de esta lista: ");
                        for (int i = 0; i < Nombres.Length; i++)

                        {
                            string elemento = Nombres[i];
                            Console.WriteLine((i + 1) + "-" + elemento);
                        }

                        int Edit = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Que quiere editar? \n" +
                            "1- Nombre \n" +
                            "2- Numero \n");
                        menu = Convert.ToInt32(Console.ReadLine());
                        switch (menu)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Escriba el nuevo nombre:");
                                Nombres[Edit-1] = Console.ReadLine();
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Escriba el nuevo numero:");
                                Numero[Edit-1] = Console.ReadLine();
                                break;

                        }
                        break;




                    case 4:
                        Console.Clear();
                        Console.WriteLine("Introduzca el contacto a eliminar de esta lista: ");
                        for (int i = 0; i < Nombres.Length; i++)

                        {
                            string elemento = Nombres[i];
                            Console.WriteLine((i + 1) + "-" + elemento);
                        }

                        int Delete = Convert.ToInt32(Console.ReadLine());
                        Nombres[Delete-1] = null;
                        Numero[Delete-1] = null;

                        Console.WriteLine("Contacto eliminado!");
                        Console.ReadKey();
                        break;


                    case 5:
                        PaCerrar = false;
                        break;






                }
                if (PaCerrar == false)
                {
                    Console.Clear();
                    Console.WriteLine("Gracias por utilizar nuestros servivicos.~");
                    Console.ReadKey();
                    break;
                }




            }

        }
    }
}
