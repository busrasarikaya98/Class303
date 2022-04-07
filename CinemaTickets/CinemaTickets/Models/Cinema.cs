
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Core.Model;

namespace WebApi.Models
{
    public class Cinema:IModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        int IModel.Id { get; set; }
    }
}
