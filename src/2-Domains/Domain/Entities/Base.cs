using Domain.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Entities
{
    public class Base : Notifier
    {
       
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
