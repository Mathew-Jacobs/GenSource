using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenSource.API.Models
{
    public enum Typings
    {

    }

    public class Creature
    {
        public int Id { get; set; }
        public Animal BaseAnimal { get; set; }
        public InanimateObject ExtraFeature { get; set; }
        public int Type1 { get; set; }
        public int Type2 { get; set; }
    }
}