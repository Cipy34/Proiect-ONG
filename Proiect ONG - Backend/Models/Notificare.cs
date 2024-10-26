using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class Notificare
    {
        [Key]
        public int notificareId {  get; set; }
        public string titlu {  get; set; }
        public string descriere { get; set; }
        public string tipNotificare { get; set; }
        public int? userId {  get; set; }
        public User user { get; set; }
        public int? ongId { get; set; }
        public Ong ong { get; set; }

    }
}
