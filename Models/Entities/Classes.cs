using CharacterCart.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CharacterCart.Models.Entities
{
    [Table("Classes", Schema="CharacterCart")]
    public class Classes : EntitiesBase
    {        
        [MaxLength(50)]
        [DataType(DataType.Text), Display(Name = "Class")]
        public string ClassesName { get; set; }

        [Display(Name = "Arcane Caster")]
        public bool IsArcaneCaster { get; set; }

        [Display(Name = "Divine Caster")]
        public bool IsDivineCaster { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ClassImage { get; set; }

        //[InverseProperty(nameof(Character.ClassId))]
        //public List<Character> Characters { get; set; } = new List<Character>();
    }
}
