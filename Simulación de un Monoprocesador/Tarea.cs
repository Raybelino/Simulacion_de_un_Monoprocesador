class Tarea
{
    public string Nombre = string.Empty;
    public int Duracion = 0;
    public Tarea(string Nombre, int Duracion)
    {
        this.Nombre = Nombre;
        this.Duracion = Duracion;
    }

    public void Ejecutar()
    {
        int segundo_en_milisegundo = 1000;

        Console.WriteLine($"Iniciando la tarea: {Nombre}");

        Thread.Sleep(Duracion * segundo_en_milisegundo);

        Console.WriteLine($"Se finalizó la tarea: {Nombre} y su duración fue: {Duracion} seg");
        Console.WriteLine("");
    }

}