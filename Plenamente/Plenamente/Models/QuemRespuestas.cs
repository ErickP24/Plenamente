﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plenamente.Models
{
    public class QuemRespuesta
    {
        [Key]
        public int Qure_Id { get; set; }
        public string Qure_Nom { get; set; }

        public ICollection<Respuesta> Respuestas { get; set; }
    }
}