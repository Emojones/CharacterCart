using CharacterCart.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CharacterCart.Models.Entities
{
    [Table("Character", Schema="CharacterCart")]
    public class Character : EntitiesBase
    {
        //character name
        [MaxLength(50), Required, ConcurrencyCheck]
        public string CharacterName { get; set; }

        //classes         
        public int ClassId { get; set; }
        [ForeignKey(nameof(ClassId))]
        public Classes Classes { get; set; }

        //race       
        public int CharacterRaceId { get; set; } 
        [ForeignKey(nameof(CharacterRaceId))]
        public CharacterRaces CharactersRaces { get; set; }

        //weapons 
        public int WeaponId { get; set; }
        [ForeignKey(nameof(WeaponId))]
        public Weapons Weapons { get; set; }

        //player
        public int PlayerId { get; set; }  
        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; }
        
    }
}