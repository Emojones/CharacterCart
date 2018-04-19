using CharacterCart.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CharacterCart.Models.Entities
{
    [Table("Player", Schema="CharacterCart")]
    public class Player : EntitiesBase
    {
        //user name
        [MaxLength(25), ConcurrencyCheck]
        [DataType(DataType.Text), Display(Name="User Name")]
        public string UserName { get; set; }

        //password
        [Required, MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //email  
        [Required, MaxLength(100)]
        [EmailAddress, DataType(DataType.EmailAddress), Display(Name = "Email Address")]
        public string Email { get; set; }

        ////Characters
        //[InverseProperty(nameof(Character.PlayerId))]
        //public List<Character> Characters { get; set; } = new List<Character>();
    }
}
