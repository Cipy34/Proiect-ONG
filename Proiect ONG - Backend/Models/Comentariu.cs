
using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class Comentariu
    {
        [Key]
        public int comentariuId { get; set; }
        public string mesaj { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public int postareId { get; set; }
        public Postare postare { get; set; }
    }
}
