using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Entity;
using Layer.AccessData;

namespace Layer.Domain
{
    public class TiempoDomain
    {
        public List<TiempoEntity> Listar()
        {
            return TiempoAccessData.Listar();
        }
    }
}
