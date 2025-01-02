using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class Sala
    {
        public PortaSala PortaSala {get;set;}
        public Porta PortaAuxiliar {get;set;}
        public float MetragemQuadrada {get;set;}

        public Sala(PortaSala portaSala, Porta portaAxiliar, float metragemQuadrada)
        {
            PortaAuxiliar = portaAxiliar;
            MetragemQuadrada = metragemQuadrada;

            PortaSala = new PortaSala(portaSala.Cor, portaSala.Largura,portaSala.Altura, portaSala.Peso);
        }

        public void AbrirPortaAuxiliar()
        {
            PortaAuxiliar.Abrir();
        }
    }
}