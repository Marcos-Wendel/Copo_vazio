using CopoVazio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.CharacterClasses
{
    public class Bosses : CriaturaViva
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
        public ClassePlayer ClasseP { get; set; } = ClassePlayer.Desconhecido;
        #endregion

        #region Constructors
        public Bosses() { }

        public Bosses(string nome)
        {
            Nome = nome;
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
        public bool Morto() => Vida is 0;

        public int Attack()
        {
            if (!Morto())
            {
                return rand.Next(_DanoMinimo, _DanoMaximo);
            }
            return 0;
        }

        public int DecreaseHealth(int Dano)
        {
            Vida -= Dano;
            Vida = Math.Max(0, Vida); 

            if (Morto())
            {
                return XpDrop;

            }

            else return 0;

        }
        #endregion

    }
}
