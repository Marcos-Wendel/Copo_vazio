using RPG.Data;
using RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPG.CharacterClasses
{
    [XmlInclude(typeof(Guerreiro))]
    [XmlInclude(typeof(Mago))]
    [XmlInclude(typeof(Ladino))]
    [XmlInclude(typeof(Item))]
    [XmlInclude(typeof(PocaoDeVida))]
    public class Jogador : IEntity
    {
        public static Type[] Types = new Type[]
        {
            typeof(Guerreiro),
            typeof(Mago),
            typeof(Ladino),
        };
        protected Random rand = new Random();

        protected int ForcaBase;
        protected int DestrezaBase;
        protected int SabedoriaBase;
        protected int VidaBase;
        protected int _Vida;
        public int MaxVida;

        // Experiencia needed for lvl 2.
        // Method for level upp will increase this value, so level 3 needs more experience.
        // Set exp dropped from monsters in NPCBase and Subclasses.
        public int ExperienciaUP = 100;
        protected int _LevelInicial = 1;
        protected int _DanoMinimo;
        protected int _DanoMaximo;
        protected int _Slot = 8;



        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Sabedoria { get; set; }
        public int Experiencia { get; set; } = 0;
        public int Level { get; set; }
        public int Vida
        {
            get
            {
                return _Vida;
            }
            set
            {
                if (value < 0) _Vida = 0;
                if (value > MaxVida) _Vida = MaxVida;
                else _Vida = value;

            }
        }
        public Item[] Inventario { get; set; }
        public EntityGender Genero { get; set; }
        public EntityClass ClasseP { get; set; }



        #region Constructors
        public Jogador() { }

        public Jogador(string name, EntityGender gender, Item[] inventory)
        {
            Nome = name;
            Genero = gender;
            Level = _LevelInicial;
            Inventario = inventory;
        }
        #endregion

        #region Combat System
        public bool Morto() => Vida is 0;
        public bool LevelUp() => Experiencia >= ExperienciaUP;

        public void ExperienceGain(int points)
        {
            Experiencia += points;
            if (LevelUp())
            {
                // Level up here, placeholder variables.
                Forca += 2;
                Sabedoria += 2;
                Destreza += 2;
                MaxVida = Vida + 5;
                Vida = MaxVida;
                Level += 1;
            }

        }

        public int Ataque()
        {
            _DanoMinimo = _DanoMinimo + Forca / 3;
            _DanoMaximo = _DanoMaximo + Forca / 3;

            if (!Morto())
            {
                return rand.Next(_DanoMinimo, _DanoMaximo + 1);
            }
            return 0;
        }

        public void TirarVida(int damage)
        {
            Vida -= damage;
        }
        #endregion

        #region Inventario

        public string AdicionarItem(Item Loot)
        {
            string msg = "";

            for (int i = 0; i < Inventario.Length; i++)
            {
                if (Inventario[i] != null)
                {
                    Inventario[i] = Loot;
                    msg = Loot.Nome + " is added to your inventory";
                }
                else
                {
                    msg = "Inventario is full";
                }
            }
            return msg;
        }

        #endregion
    }

    
}
