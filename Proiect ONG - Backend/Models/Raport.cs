using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class Raport
    {
        [Key]
        public int raportId { get; set; }
        public string titlu {  get; set; }
        public string mesaj { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
    }
}
