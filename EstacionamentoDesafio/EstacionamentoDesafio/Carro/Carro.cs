using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoDesafio.Carro
{
    class Carro
    {
        private String placa;
        private String marca;
        private String modelo;
        private Int32 vaga;
        private String horaEntrada;
        private String horaSaida;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Vaga { get => vaga; set => vaga = value; }
    }
}
