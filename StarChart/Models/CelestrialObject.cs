﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestrialObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? OrbitedObject { get; set; }
        [NotMapped]
        public List<CelestrialObject> Satelites { get; set; }
        public TimeSpan OrbitalPeriod { get; set; }
    }
}
