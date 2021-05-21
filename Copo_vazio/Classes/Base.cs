using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.CharacterClasses
{
    public enum EntityGender { Male, Female, Unknown };
    public enum EntityClass { Shaman, Berserker, Rogue, Warrior, Wizard, Unknown };

    interface IEntity
    {
        string Nome { get; }
        int Froca { get; set; }
        int Destreza { get; set; }
        int sabedoria { get; set; }
        int vida { get; set; }
        EntityGender Gender { get; set; }
        EntityClass CharacterClass { get; set; }

    }
}
