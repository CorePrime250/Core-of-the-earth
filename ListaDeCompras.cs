using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompra
{
    class Program
    {
        static void Main(string[] args)
        {
            bool PaCerrar = true;
            string[] Vegetales = new string[10];
            string[] Frutas = new string[10];
            string[] Lacteos = new string[10];
            
            while (PaCerrar)
            {
                
                int menu = 0;

                Console.WriteLine("Bienvenido a su lista de compras, elija la opcion necesaria: \n" +
              "\n 1- Ver lista \n" +
              "\n 2- Agregar a la lista \n" +
              "\n 3- Editar la lista \n" +
              "\n 4- Eliminar.\n" +
              "\n 5- Salir");

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n Lista de Lacteos: \n");

                        for (int i = 0; i < Lacteos.Length; i++)
                        {
                            string elemento = Lacteos[i];

                            Console.WriteLine((i + 1) + "-" + elemento);
                        }

                        Console.WriteLine("\n Lista de Frutas: \n");

                        for (int i = 0; i < Frutas.Length; i++)
                        {
                            string elemento = Frutas[i];

                            Console.WriteLine((i + 1) + "-" + elemento);
                        }

                        Console.WriteLine("\n Lista de Vegetales: \n");

                        for (int i = 0; i < Vegetales.Length; i++)
                        {
                            string elemento = Vegetales[i];

                            Console.WriteLine((i + 1) + "-" + elemento);
                        }

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Introduzca la lista a la que quiera agregar el producto: \n" +
                            "1- Vegetales \n" +
                            "2- Frutas \n" +
                            "3- Lacteos");
                        menu = Convert.ToInt32(Console.ReadLine());

                        switch (menu)
                        {
                            case 1:
                                if (string.IsNullOrEmpty(Frutas[9]))
                                {
                                    for (int i = 0; i < Vegetales.Length; i++)
                                    {
                                        string elemento = Vegetales[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            Console.WriteLine("Introduzca el producto:");
                                            Vegetales[i] = Console.ReadLine();
                                            Console.Clear();

                                            break;
                                        }

                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No caben mas elementos en esta lista.");
                                }
                                break;

                            case 2:

                                if (string.IsNullOrEmpty(Frutas[9]))
                                {
                                    for (int i = 0; i < Frutas.Length; i++)
                                    {
                                        string elemento = Frutas[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            Console.WriteLine("Introduzca el producto:");
                                            Frutas[i] = Console.ReadLine();
                                            Console.Clear();

                                            break;
                                        }

                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No caben mas elementos en esta lista.");
                                }
                                break;

                            case 3:
                                if (string.IsNullOrEmpty(Lacteos[9]))
                                {
                                    for (int i = 0; i < Lacteos.Length; i++)
                                    {
                                        string elemento = Lacteos[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            Console.WriteLine("Introduzca el producto:");
                                            Lacteos[i] = Console.ReadLine();
                                            Console.Clear();

                                            break;
                                        }

                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No caben mas elementos en esta lista.");
                                }
                                break;


                        }
                        break;

                    case 3:
                        Console.Clear();
                       
                        Console.WriteLine("Introduzca la lista a la que quiera editar: \n" +
                            "1- Vegetales \n" +
                            "2- Frutas \n" +
                            "3- Lacteos");
                        menu = Convert.ToInt32(Console.ReadLine());

                        switch (menu)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Introduzca el numero del producto a editar de esta lista: ");
                                for (int i = 0; i < Vegetales.Length; i++)

                                {
                                    string elemento = Vegetales[i];
                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }

                                int Edit = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Escriba el nuevo producto:");
                                Vegetales[Edit - 1] = Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("Introduzca el numero del producto a editar de esta lista: ");
                                for (int i = 0; i < Frutas.Length; i++)

                                {
                                    string elemento = Frutas[i];
                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }

                                int Edit2 = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Escriba el nuevo producto:");
                                Frutas[Edit2 - 1] = Console.ReadLine();
                                Console.Clear();
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Introduzca el numero del producto a editar de esta lista: ");
                                for (int i = 0; i < Lacteos.Length; i++)

                                {
                                    string elemento = Lacteos[i];
                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }

                                int Edit3 = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("Escriba el nuevo producto:");
                                Lacteos[Edit3 - 1] = Console.ReadLine();
                                Console.Clear();
                                break;



                        }
                        break;





                    case 4:
                        Console.Clear();

                        Console.WriteLine("Introduzca la lista a la que quiera editar: \n" +
                            "1- Vegetales \n" +
                            "2- Frutas \n" +
                            "3- Lacteos");
                        menu = Convert.ToInt32(Console.ReadLine());

                        switch (menu)
                        {
                            case 1:
                                Console.Clear();
                                int Delete = 0;
                                Console.WriteLine("Introduzca el numero del producto a eliminar de esta lista: ");
                                for (int i = 0; i < Vegetales.Length; i++)

                                {
                                    string elemento = Vegetales[i];
                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }

                                Delete = Convert.ToInt32(Console.ReadLine());
                                Vegetales[Delete-1] = null;
                                Console.WriteLine("Producto eliminado!");
                                Console.ReadKey();
                                Console.Clear();
                                break;



                                
                            case 2:
                                Console.Clear();
                                int Delete2 = 0;
                                Console.WriteLine("Introduzca el numero del producto a eliminar de esta lista: ");
                                for (int i = 0; i < Frutas.Length; i++)

                                {
                                    string elemento = Frutas[i];
                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }

                                Delete2 = Convert.ToInt32(Console.ReadLine());
                                Frutas[Delete2-1] = null;
                                Console.WriteLine("Producto eliminado!");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                                

                            case 3:
                                Console.Clear();
                                int Delete3 = 0;
                                Console.WriteLine("Introduzca el numero del producto a eliminar de esta lista: ");
                                for (int i = 0; i < Lacteos.Length; i++)

                                {
                                    string elemento = Lacteos[i];
                                    Console.WriteLine((i + 1) + "-" + elemento);
                                }

                                Delete3 = Convert.ToInt32(Console.ReadLine());
                                Lacteos[Delete3-1] = null;
                                Console.WriteLine("Producto eliminado!");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                                

                        }
                        break;

                        

                    case 5:
                        PaCerrar = false;
                        Console.Clear();
                        break;


                }

                if (PaCerrar== false)
                {
                    Console.WriteLine("Gracias por utilizar nuestros servivicos.~");
                    Console.ReadKey();
                    break;
                }

            }
            

            
            



    }


        }
    }


