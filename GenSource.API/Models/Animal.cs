using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenSource.API.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float[] Weights { get; set; }
    }
}