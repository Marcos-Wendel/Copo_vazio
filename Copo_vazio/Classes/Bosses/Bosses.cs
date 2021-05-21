using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.CharacterClasses
{
    public class Bosses : IEntity
    {
        protected Random rand = new Random();
        protected int _DanoMinimo;
        protected int _DanoMaximo;
        protected int _XpDrop;

        #region Properties
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Sabedoria { get; set; }
        public int Vida { get; set; }
        public int XpDrop { get; set; }
        public EntityGender Gender { get; set; } = EntityGender.Unknown;
        public EntityClass CharacterClass { get; set; } = EntityClass.Unknown;
        #endregion

        #region Constructors
        public Bosses() { }

        public Bosses(string name)
        {
            Nome = name;
        }
        #endregion

        #region General Methods

        public Bosses NovoInimigo()
        {
            Bosses[] _Bosses = new Bosses[]{
            new Beholder ("Beholder") };

            Random rand = new Random();
            int next = rand.Next(0, _Bosses.Length);

            if (_Bosses != null)
            {
                return _Bosses[next];
            }
            return null;
        }

        #endregion

        #region Combat Methods
        public bool IsDead() => Vida is 0;

        public int Attack()
        {
            if (!IsDead())
            {
                return rand.Next(_DanoMinimo, _DanoMaximo);
            }
            return 0;
        }

        public int DecreaseHealth(int Dano)
        {
            Vida -= Dano;
            Vida = Math.Max(0, Vida); // Sets health to 0 if it goes below.

            if (IsDead())
            {
                return XpDrop; // Drop exp if dead

            }

            else return 0;

        }



        // Add method, NPC is defeated.
        // Give experience?


        #endregion

    }
}
