using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.EF.Models
{
    public class States
    {
        [Key]
        public Int16 stateID { get; set; }
        public string stateName { get; set; }
        public string stateAbbrev { get; set; }
    }
}
