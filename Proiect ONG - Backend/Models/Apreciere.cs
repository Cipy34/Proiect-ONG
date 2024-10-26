using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class Apreciere
    {
        [Key]
        public int apreciereId {  get; set; }
        public int userId {  get; set; }
        public User user { get; set; }
        public int postareId { get; set; }
        public Postare postare {  get; set; }
    }
}
