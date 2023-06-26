﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class ActividadEmpresa
    {

        [Key]
        public int IdActividadEmpresa { get; set; }
        public string Descripcion { get; set; }


        public virtual List<Cliente> Cliente { get; set; }

    }


}

