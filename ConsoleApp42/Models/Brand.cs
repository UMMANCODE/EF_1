﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42.Models {
    public class Brand {
        public int Id { get; set; }
        public string Name { get; set; }

        public Brand() { }


        public Brand(string name) {

            Name = name;
        }

        public override string ToString() {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
