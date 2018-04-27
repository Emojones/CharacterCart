using CharacterCart.DAL.EfStructures;
using CharacterCart.DAL.Repos.Base;
using CharacterCart.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterCart.DAL.Repos
{
    public class WeaponsRepo : RepoBase<Weapons>, IWeaponsRepo
    {
        public WeaponsRepo() { }
        public WeaponsRepo(CharacterCartContext context) : base(context) { }
        public override IList<Weapons> GetAll() => Table.OrderBy(x => x.WeaponName).ToList();
    }
}
