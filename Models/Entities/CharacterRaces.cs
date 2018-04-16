using CharacterCart.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CharacterCart.Models.Entities
{
    [Table("CharacterRaces", Schema="CharacterCart")]
    public class CharacterRaces : EntitiesBase
    {       
        [MaxLength(50)]
        [DataType(DataType.Text), Display(Name = "Race Name")]
        public string CharacterRacesName { get; set; }

        [InverseProperty(nameof(Character.CharacterRaceId))]
        public List<Character> Characters { get; set; } = new List<Character>();       
    }
}
