using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.CharacterClasses
{
    public enum ClassePlayer {Ladino, Mago, Guerreiro, Desconhecido};

    interface IEntity
    {
        string Nome { get; }
        int Forca { get; set; }
        int Destreza { get; set; }
        int sabedoria { get; set; }
        int vida { get; set; }

        ClassePlayer ClasseP { get; set; }

    }
}
