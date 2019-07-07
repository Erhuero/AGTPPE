//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AGTPPE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class TICKETS
    {
        public int idTickets { get; set; }

        [Required]
        [Display(Name = "Emplacement du matériel ")]
        public string emplacementMaterielTicket { get; set; }

        [Required]
        [Display(Name = "Type de matériel ")]
        public string typeMaterielTicket { get; set; }
        public IEnumerable<SelectListItem> TypeMateriel{ get; set; }

        [Required]
        [Display(Name = "Niveau d'urgence ")]
        public Nullable<int> niveauUrgenceTicket { get; set; }
        public IEnumerable<SelectListItem> UrgenceNiveau { get; set; }

        [Required]
        [Display(Name = "Description de l'incident")]
        [StringLength(500)]
        public string descriptionIncident { get; set; }

        public Nullable<System.DateTime> dateCreationTicket { get; set; }
        public Nullable<System.DateTime> dateClotureTicket { get; set; }
        public Nullable<int> idUtilisateur { get; set; }
        public string numeroSerieMateriel { get; set; }
    
        public virtual MATERIEL MATERIEL { get; set; }
        public virtual UTILISATEUR UTILISATEUR { get; set; }
    }
}
