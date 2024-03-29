﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.CharacterClasses
{
    public class Beholder : Bosses
    {
        // Fields
        private int _defaultStrength = 0;
        private int _defaultDexterity = 1;
        private int _defaultWisdom = 2;
        private int _defaultHealth = 15;
        private string _nome = "Beholder";

        private int _BeholderExp = 100;

        private int _BeholderDanoMinimo = 1;
        private int _BeholderDanoMaximo = 4;


        // Constructor
        public BossBeholder()
        {

        }

        public BossBeholder(string nome) : base(nome)
        {
            Nome = _nome;
            Forca = _defaultStrength;
            Destreza = _defaultDexterity;
            Sabedoria = _defaultWisdom;
            Vida = _defaultHealth;
            XpDrop = _BeholderExp;

            _DanoMinimo = _BeholderDanoMinimo;
            _DanoMaximo = _BeholderDanoMaximo;

        }  
    }
}
