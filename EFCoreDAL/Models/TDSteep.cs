using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreDAL.Models
{
    public class TDSteep
    {
        [Key]
        public int Id { get; set; }    
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public Boolean Done { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
