using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTryeDispose
{

    class Cliente

    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Tipo TipoPessoa { get; set; }
    }
    public enum Tipo
    {
        Cliente = 10,
        Fornecedor = 20
    }
}

