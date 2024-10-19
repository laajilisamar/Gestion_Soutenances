using System.ComponentModel.DataAnnotations;

namespace GestionSoutenances.Models
{
    public class PFE_Etudiant
    {
        public int ID { get; set; }
        [Display(Name = "pfe")]


        // Foreign Keys
        public int PFEID { get; set; }
        [Display(Name = "Etudiant")]

        public int EtudiantID { get; set; }

        public virtual Etudiant? Etudiant { get; set; }

        // Navigation properties
        public virtual PFE? PFE { get; set; }
    }
}
