namespace CapturaDeProspectos.Models

{
    public class Prospecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Colonia { get; set; }
        public string Telefono { get; set; }
        public string RFC { get; set; }

        public string CP { get; set; }

        public string Status { get; set; }
        public string Observaciones { get; set; }
    }
}
