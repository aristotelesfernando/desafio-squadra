using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Gerenciamento_Lead
    {
        public Guid Id { get; set; }
        public string Contact_First_Name { get; set; }
        public string Contact_Full_Name { get; set; }
        public string Contact_Phone_Number { get; set; }
        public string Contact_Email { get; set; }
        public DateTime Date_Created { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Gerenciamento_Lead()
        {
            Id = Guid.NewGuid();
        }
    }
}
