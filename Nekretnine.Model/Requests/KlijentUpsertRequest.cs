using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nekretnine.Model.Requests
{
    public class KlijentUpsertRequest
    {
        public int KlijentId { get; set; }

        [Required(ErrorMessage = "{0} je obavezno polje")]
        [MaxLength(50, ErrorMessage = "Polje {0} ne smije biti duže od {1} karaktra")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "{0} je obavezno polje")]
        [MaxLength(50, ErrorMessage = "Polje {0} ne smije biti duže od {1} karaktra")]
        public string Prezime { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Polje {0} ne smije biti duže od {1} karaktra")]
        [Phone(ErrorMessage = "{0} biti u formatu broja telefona")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "{0}  je obavezno polje")]
        [MaxLength(100, ErrorMessage = "Polje {0} ne smije biti duže od {1} karaktra")]
        public string Adresa { get; set; }

        [Required(ErrorMessage = "{0} je obavezno polje")]
        [EmailAddress(ErrorMessage = "{0} biti u formatu email adrese")]
        [MaxLength(50, ErrorMessage = "Polje {0} ne smije biti duže od {1} karaktra")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Datum rođenja je obavezno polje")]
        public DateTime? DatumRodjenja { get; set; }

        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        [Required(ErrorMessage = "{0}  je obavezno polje")]
        public int? GradId { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "Polje {0} ne smije biti duže od {1} karaktra")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "Polje {0} ne smije biti duže od {1} karaktra")]
        [Compare("Password", ErrorMessage = "Polje Password i PasswordPotvrda se moraju podudarati")]
        public string PotvrdaPassworda { get; set; }

        [Required]
        public bool? Status { get; set; }


    }



}

