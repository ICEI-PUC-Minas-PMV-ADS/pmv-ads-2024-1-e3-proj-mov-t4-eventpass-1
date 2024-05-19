namespace EventPass.Models
{
    public class Ingresso
    {
        public int Id { get; set; }
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public Evento Evento { get; set; }
        public Usuario Usuario { get; set; }
    }
}

