using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class Interactiune
    {
        [Key]
        public int interactiuneId { get; set; }
        public string tipInteractiune { get; set; }
        public DateTime data {  get; set; }
        public int? suma {  get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public int postareId {  get; set; }
        public Postare postare { get; set; }
    }
}
