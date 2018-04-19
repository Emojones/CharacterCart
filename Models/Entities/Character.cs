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
        public Classes ClassId { get; set; }

        //race       
        public CharacterRaces CharacterRaceId { get; set; }       

        //weapons 
        public Weapons WeaponId { get; set; }

        //player
        public Player PlayerId { get; set; }        
        
    }
}