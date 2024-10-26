namespace Proiect_ONG___Backend.Models.DTOs
{
    public class InteractiuneDTO
    {
        public string tipInteractiune {  get; set; }
        public DateTime data {  get; set; }
        public int suma { get; set; }
        public int userId { get; set; }
        public int postareId { get; set; }
    }
}
