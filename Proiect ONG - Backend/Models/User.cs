using System.ComponentModel.DataAnnotations;

namespace Proiect_ONG___Backend.Models
{
    public class User
    {
        [Key]
        public int userId {  get; set; }
        public string nume {  get; set; }
        public string prenume { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string parola { get; set; }
        public string pozaProfil { get; set; }
        public bool voluntar {  get; set; }
        public bool verificat { get; set; }
        public int puncte { get; set; }
        public ICollection<Interactiune> interactiuni { get; set; }
        public ICollection<Notificare> notificari { get; set; }
        public ICollection<Apreciere> aprecieri { get; set; }
        public ICollection<Comentariu> comentarii { get; set; }
        public ICollection<Raport> raportari { get; set; }
    }
}
