class Monoprocesador
{
    private List<Tarea> cola_tareas = new List<Tarea>();

    public void Agregar_Tareas(Tarea tarea)
    {
        cola_tareas.Add(tarea);
        Console.WriteLine("");
        Console.WriteLine($"La tarea '{tarea.Nombre}' fue agregada a la cola.");
        Console.WriteLine("");
    }

    public void Ejecutar_Tareas()
    {
        Console.WriteLine("");
        Console.WriteLine("====== Iniciando la ejecución de las tareas ======");
        Console.WriteLine("");

        for (int i = 0; i < cola_tareas.Count; i++)
        {
            cola_tareas[i].Ejecutar();
        }

        Console.WriteLine("========== Se han finalizado las tareas ==========");
        Console.WriteLine("");
    }
}