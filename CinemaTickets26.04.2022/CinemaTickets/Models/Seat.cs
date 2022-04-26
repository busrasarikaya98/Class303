using System;
using WebApi.Core.Model;

namespace WebApi.Models
{
    public class Seat:IModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Seat()
        {

        }
        public Seat(int id, string number)
        {
            Id = id;
            Number = number;
        }
    }
}
