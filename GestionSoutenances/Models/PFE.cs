using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace GestionSoutenances.Models
{
    public class PFE
    {
        public int PFEID { get; set; }

        [Required(ErrorMessage ="Titre obligatoire")]
        [StringLength(30, MinimumLength = 3)]
        public string Titre { get; set; }


        [Display(Name = "descrption")]
        public string Description { get; set; }

        [Required(ErrorMessage = "date de debut obligatoire")]
        [Display(Name = "Date Debut")]
        public DateTime DateDebut { get; set; }

        [Required(ErrorMessage = "Date Fin obligatoire")]
        [Display(Name = "DateFin")]
        public DateTime DateFin { get; set; }
        [Display(Name = "Encadrant")]


        public int EncadrantID { get; set; }
        public int SocieteID { get; set; }

        public virtual Enseignant? Encadrant { get; set; }
        public virtual Societe? Societe { get; set; }
        public   ICollection<PFE_Etudiant>? PFE_Etudiant { get; set; }


    }
}
