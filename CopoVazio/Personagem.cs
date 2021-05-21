using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopoVazio
{
    public class Personagem : CriaturaViva
    {
        public List<Itens> Inventario { get; set; }

        public Personagem(int armadura, decimal vida)
        {
            vida = HP;
            
        }
    }
}
