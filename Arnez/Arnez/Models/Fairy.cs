namespace Arnez.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Fairy

    {
        public enum WishType

        {
            Avion,
            Abeja,
            Avispa

        }
        [Key]
        public int FairyID { get; set; }

        [Required]
        [Display(Name ="Nombre Completo")]
        [StringLength(24,MinimumLength =2)]
        public string NickName { get; set; }

        [Required]
        public WishType Wishes { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Direccion de correo no valida")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }


    }
}