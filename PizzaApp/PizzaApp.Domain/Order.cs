using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace PizzaApp.Domain
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public List<Pizza> Pizzas { get; set; }

        public double TotalPrice
        {
            get => Pizzas.Sum(x => x.Price) + 10;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
