using CopoVazio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPG.CharacterClasses
{
    [XmlRoot(Namespace = "Jogador")]
    public class Ladino : Jogador
    {
        #region Fields
        private int _ForcaBase = 0;
        private int _DestrezaBase = 5;
        private int _SabedoriaBase = 15;
        private int _VidaBase = 13;
        private Itens[] _Inventario = new Itens[] { new PocaoDeCura("Poção de Cura", "Poções de Cura", 6), new PocaoDeCura("Poção de Cura", "Poções de Cura", 6), new PocaoDeCura("Poção de Cura", "Poções de Cura", 6) };
        private int _DanoMinimo = 2;
        private int _DanoMaximo = 6;
        #endregion

        #region Constructors
        public Ladino()
        {
            ClasseP = ClassePlayer.Ladino;
            Forca = _ForcaBase;
            Destreza = _DestrezaBase;
            Sabedoria = _SabedoriaBase;
            MaxVida = _VidaBase;
            Vida = _VidaBase;
            _DanoMinimo = _DanoMinimo;
            _DanoMaximo = _DanoMaximo;
            Inventario = _Inventario;
        }

        public Ladino(string nome, Itens[] Inventario) : base(nome, Inventario)
        {
            ClasseP = ClassePlayer.Ladino;
            Forca = _ForcaBase;
            Destreza = _DestrezaBase;
            Sabedoria = _SabedoriaBase;
            Vida = _VidaBase;
            MaxVida = _VidaBase;
            Inventario = _Inventario;
            _DanoMinimo = _DanoMinimo;
            _DanoMaximo = _DanoMaximo;
        }
        #endregion


    }

}
