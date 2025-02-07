public class MathAssignment : Assignment
{
    private readonly string _seccionLibro;
    private readonly string _ejercicios;

    public MathAssignment(string nombreEstudiante, string tema, string seccionLibro, string ejercicios)
        : base(nombreEstudiante, tema)
    {
        _seccionLibro = seccionLibro;
        _ejercicios = ejercicios;
    }

    public string ObtenerListaDeEjercicios()
    {
        return $"Sección {_seccionLibro}, Ejercicios {_ejercicios}";
    }
}
