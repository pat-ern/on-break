using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class CoffeeBreak
{
    [Key]
    public string Numero { get; set; }
    public bool Vegetariana { get; set; }

    
    }

}
