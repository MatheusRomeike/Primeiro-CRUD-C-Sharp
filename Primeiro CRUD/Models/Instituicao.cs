using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro_CRUD.Models
{
    public class Instituicao
    {
        public long? InstituicaoID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
