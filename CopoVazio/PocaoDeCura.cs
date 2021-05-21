using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopoVazio
{
    public class PocaoDeCura : Itens
    {
        public int Cura { get; set; }
        public PocaoDeCura(string nome, string nomePlural, int usarPocaoDeCura)
        {
            nome = Nome;
            nomePlural = NomePlural;
            nome = "Poção de Cura";
            nomePlural = "Poções de Cura";
            usarPocaoDeCura = Cura;

            Random CuraHP = new Random();
            usarPocaoDeCura = CuraHP.Next(6 + 1);
        }
    }
}
