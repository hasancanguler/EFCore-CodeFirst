using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreDAL.Models
{
    public class TDTask
    {
        [Key]
        public int Id { get; set; }
        public ICollection<TDSteep> TDSteep { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public Boolean Done { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
