using CharacterCart.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CharacterCart.Models.ViewModels.Base
{
    public class CharacterDetailBase : EntitiesBase
    {
        [Display(Name = "Character Name")]
        public string CharacterName { get; set; }

        [Display(Name = "Race")]
        public string CharacterRace { get; set; }

        [Display(Name = "Class")]
        public string ClassesName { get; set; }

        [Display(Name = "Arcane Caster")]
        public bool IsArcaneCaster { get; set; }

        [Display(Name = "Divine Caster")]
        public bool IsDivineCaster { get; set; }

        public string ClassImage { get; set; }
        
        [Display(Name = "Weapons")]
        public string WeaponName { get; set; }  
        
        [Display(Name ="Ranged Weapon")]
        public bool IsRanged { get; set; }

        public string WeaponImage { get; set; }


    }
}
