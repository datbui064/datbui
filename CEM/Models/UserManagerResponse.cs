using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEM.Models
{
    public class UserManagerResponse
    {
        public string Message { get; set; }

        public string IsSuccess { get; set; }

        public string[] Error { get; set; }

        public DateTime? ExpireDate { get; set; }
    }
}
