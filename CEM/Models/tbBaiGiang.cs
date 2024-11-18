using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CEM.Models
{
    [Table("tbBaiGiang")]
    public partial class tbBaiGiang
    {
        [Key]
        public int ID { get; set; }


    }
}