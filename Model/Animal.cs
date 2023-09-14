using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Desktop.Model
{
    internal class Animal
    {

        public Animal() { }

        public int CodAnimal { get; set; }
        public string NomeAnimal { get; set; }
        public string RacaAnimal { get; set; }
        public string CorAnimal { get; set; }
        public String PesoAnimal { get; set; }
        public string NomeProprietario { get; set; }
        public byte[] Foto { get; set; } // Novo campo para a foto

    }
}
