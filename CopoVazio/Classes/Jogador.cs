using CopoVazio;
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
    [XmlInclude(typeof(Itens))]
    [XmlInclude(typeof(PocaoDeCura))]
    public class Jogador : CriaturaViva
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

        // Experiencia necessaria pro lvl 2.
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
        public Itens[] Inventario { get; set; }
        public ClassePlayer ClasseP { get; set; }



        #region Constructors
        public Jogador() { }

        public Jogador(string nome, Itens[] inventario)
        {
            Nome = nome;
            Level = _LevelInicial;
            Inventario = inventario;
        }
        #endregion

        #region Combat System
        public bool Morto() => Vida is 0;
        public bool LevelUp() => Experiencia >= ExperienciaUP;

        public void ExperienceGain(int xp)
        {
            Experiencia += xp;
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

        public void TirarVida(int dano)
        {
            Vida -= dano;
        }
        #endregion

        #region Inventario

        public string AdicionarItem(Itens Loot)
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
