﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsedCars.Entities
{
    public class Model
    {
        [Key]
        public Guid Id { get; set; }


        public string Name { get; set; }

       

        ICollection<Vehicle> Vehicles { get; set; }


    }
}
