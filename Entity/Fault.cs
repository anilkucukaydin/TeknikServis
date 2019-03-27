using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Fault : IEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string ProductCategory { get; set; }
        public bool isRepaired { get; set; }
        public bool isDirected { get; set; }
        public string ImageURL { get; set; }
        public string Message { get; set; }
        public DateTime RequestDate { get; set; }
        public virtual Person Person { get; set; }
        public Fault()
        {
            RequestDate = DateTime.Now;
        }
    }
}
