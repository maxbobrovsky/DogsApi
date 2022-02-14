using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Dog
    {
        [Column("DogId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Dog name is a required field.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Color is a required field.")]
        public string Color { get; set; }
        
        [Column("tail_length")]
        [Required(ErrorMessage = "Tail length is a required field.")]
        public int Tail_Length { get; set; }

        [Column("weight")]
        [Required(ErrorMessage = "Weight is a required field.")]
        public int Weight { get; set; }
    }
}
