using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CharacterCart.Models.Entities
{
    [Table("Characters", Schema="CharacterCart")]
    public class Character
    {
        //character name
        [MaxLength(50), Required, ConcurrencyCheck]
        public string CharacterName { get; set; }

        //classes
        public int ClassId { get; set; }
        [ForeignKey(nameof(ClassId))]
        public Classes Class { get; set; }

        //race
        public int CharacterRaceId { get; set; }
        [ForeignKey(nameof(CharacterRaceId))]
        public CharacterRaces CharacterRace { get; set; }

        //weapons
        public int WeaponId { get; set; }
        [ForeignKey(nameof(WeaponId))]
        public Weapons Weapon { get; set; }

        //player
        public int PlayerId { get; set; }
        [InverseProperty(nameof(PlayerId))]
        public List<Player> Players { get; set; } = new List<Player>();

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; }
        
    }
}
