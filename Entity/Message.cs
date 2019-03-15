using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Message : IEntity
    {
        public int Id { get; set; }
        public int MessageFrom { get; set; }
        public int MessageTo { get; set; }
        public string Text { get; set; }
        public DateTime SendDate { get; set; }
        public string ImageURL { get; set; }
        public Message()
        {
            SendDate = DateTime.Now;
        }

    }
}
