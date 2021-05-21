using RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPG.CharacterClasses
{
    [XmlRoot(Namespace = "Jogador")]
    public class Mago : Jogador
    {
        #region Fields
        private int _ForcaBase = 0;
        private int _DestrezaBase = 5;
        private int _SabedoriaBase = 15;
        private int _VidaBase = 13;
        private Item[] _Inventario = new Item[] { new PocaoDeVida(), new PocaoDeVida(), new PocaoDeVida() };
        private int _DanoMinimo = 2;
        private int _DanoMaximo = 6;
        #endregion

        #region Constructors
        public Mago()
        {
            ClasseP = EntityClass.Mago;
            Forca = _ForcaBase;
            Destreza = _DestrezaBase;
            Sabedoria = _SabedoriaBase;
            MaxVida = _VidaBase;
            Vida = _VidaBase;
            _DanoMinimo = _DanoMinimo;
            _DanoMaximo = _DanoMaximo;
            Inventory = _Inventario;
        }

        public Mago(string name, EntityGender gender, Item[] Inventario) : base(name, gender, Inventario)
        {
            CharacterClass = EntityClass.Mago;
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
