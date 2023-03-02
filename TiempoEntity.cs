using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Entity
{
    public class TiempoEntity
    {
        public int idTiempo { get; set; }
        public string dataLocal { get; set; }
        public string dataUTC { get; set; }
        public string icoEstadoCeo { get; set; }
        public string icoVento { get; set; }
        public string idConcello { get; set; }
        public string nomeConcello { get; set; }
        public string sensacionTermica { get; set; }
        public string temperatura { get; set; }


    }
}
