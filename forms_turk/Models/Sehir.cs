﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Models
{
   public class Sehir
    {
       
        public int Id { get; set; }

        [Required]
        public string SehirAdi { get; set; }
    }
}
