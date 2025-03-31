namespace EventosWebApp.Models;

public class Evento
{
    public DateTime DataIni { get; set; }
    public DateTime DataFim { get; set; }
    public required string Description { get; set; }
    public int TipoEvento { get; set; }
    public bool Ativo { get; set; }
}