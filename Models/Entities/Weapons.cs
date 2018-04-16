using CharacterCart.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CharacterCart.Models.Entities
{
    [Table("Weapons", Schema = "CharacterCart")]
    public class Weapons : EntitiesBase
    {
        [MaxLength(50)]
        [Required]
        public string WeaponName { get; set; }

        [DataType(DataType.ImageUrl)]
        public string WeaponImage { get; set; }

        //default shold be 0
        [Display(Name = "Ranged Weapon")]
        public bool IsRanged { get; set; }

        [InverseProperty(nameof(Character.WeaponId))]
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
