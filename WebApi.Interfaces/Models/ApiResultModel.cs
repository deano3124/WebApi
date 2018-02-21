using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Interfaces.Models
{
    public class ApiResultModel
    {
        public ApiResultModel()
        {
            Errors = new List<string>();
            Details = new List<string>();
        }

        public IList<string> Errors { get; set; }

        public IList<string> Details { get; set; }
    }
}
