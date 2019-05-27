﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plenamente.Models
{
    public class PlandeTrabajo
    {
        [Key]
        public int Plat_Id { get; set; }
        public string Plat_Nom { get; set; }

        // Permite que Acummes acceda a la data
        public ICollection<Usersplandetrabajo> Usersplandetrabajo { get; set; }

    }
}