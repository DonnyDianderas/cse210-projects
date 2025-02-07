public class WritingAssignment : Assignment
{
    private readonly string _titulo;

    public WritingAssignment(string nombreEstudiante, string tema, string titulo)
        : base(nombreEstudiante, tema)
    {
        _titulo = titulo;
    }

    public string ObtenerInformacionEscrita()
    {
        return $"{_titulo} por {NombreEstudiante}";
    }
}