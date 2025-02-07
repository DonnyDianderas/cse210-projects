public class Assignment
{
    protected string NombreEstudiante { get; }
    protected string Tema { get; }

    public Assignment(string nombreEstudiante, string tema)
    {
        NombreEstudiante = nombreEstudiante;
        Tema = tema;
    }

    public string ObtenerResumen()
    {
        return $"{NombreEstudiante} - {Tema}";
    }
}
