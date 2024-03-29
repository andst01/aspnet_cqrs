using System;
using System.Collections.Generic;
using System.Text;

namespace SGAS.Domain.Notifications
{
    public class ItemServicoDeleteEvent : EventBase
    {
        public ItemServicoDeleteEvent(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
