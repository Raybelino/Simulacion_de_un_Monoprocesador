namespace Simulador_Monoprocesador
{
    class Program
    {
        static void Main()
        {
            Monoprocesador monoprocesador = new Monoprocesador();
            string? nombre = string.Empty;
            int duracion = 0;

            Console.WriteLine("====== Simulación de Monoprocesador ======");
            Console.WriteLine("");

            while (true)
            {
                Console.Write("¿Deseas ingresar tareas manualmente? (s/n): ");
                string? respuesta = Console.ReadLine();
                Console.WriteLine("");
                if (string.IsNullOrEmpty(respuesta) || (respuesta != "s" && respuesta != "n"))
                {
                    Console.WriteLine("Debes de ingresar 's' para SI o 'n' para NO");
                    Console.WriteLine("");
                    continue;
                }

                if (respuesta.ToLower() == "s")
                {
                    while (true)
                    {
                        while (true)
                        {
                            Console.Write("Nombre de la tarea: ");
                            nombre = Console.ReadLine();

                            if (string.IsNullOrEmpty(nombre))
                            {
                                Console.WriteLine("Se debes de poner un nombre");
                                Console.WriteLine("");
                                continue;
                            }
                            break;
                        }
                        while (true)
                        {
                            Console.Write("Duración de la tarea en segundos: ");
                            if (!int.TryParse(Console.ReadLine(), out duracion))
                            {
                                Console.WriteLine("Se debe de poner la duracion en segundos");
                                Console.WriteLine("");
                                continue;
                            }
                            break;
                        }

                        monoprocesador.Agregar_Tareas(new Tarea(nombre, duracion));

                        string? repetir = string.Empty;

                        while (true)
                        {

                            Console.Write("¿Deseas agregar mas tareas? (s/n): ");
                            repetir = Console.ReadLine();

                            if (string.IsNullOrEmpty(repetir) || (repetir != "s" && repetir != "n"))
                            {
                                Console.WriteLine("Debes de ingresar 's' para SI o 'n' para NO");
                                Console.WriteLine("");
                                continue;
                            }
                            Console.WriteLine("");
                            break;
                        }

                        if (repetir.ToLower() == "n")
                            break;

                        continue;
                    }
                }
                else
                {
                    monoprocesador.Agregar_Tareas(new Tarea("Cargar sistema operativo", 2));
                    monoprocesador.Agregar_Tareas(new Tarea("Abrir navegador", 3));
                    monoprocesador.Agregar_Tareas(new Tarea("Reproducir video", 4));
                }

                monoprocesador.Ejecutar_Tareas();

                Console.WriteLine("Se termino la simulacion del monoprocesador");
                break;
            }
        }
    }
}