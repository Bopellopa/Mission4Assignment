using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    //new model
    public class GradeCModel
    {
        //makes the user enter a number within our selected range and alerts with error if condition isnt met
        [Range(0, 100, ErrorMessage = "Percent must be between 0 and 100")]
        //DataType of expected user input, get and set receive and post information
        public float assn { get; set; }

        [Range(0, 100, ErrorMessage = "Percent must be between 0 and 100")]
        public float gp { get; set; }

        [Range(0, 100, ErrorMessage = "Percent must be between 0 and 100")]
        public float quiz { get; set; }

        [Range(0, 100, ErrorMessage = "Percent must be between 0 and 100")]
        public float mid { get; set; }

        [Range(0, 100, ErrorMessage = "Percent must be between 0 and 100")]
        public float final { get; set; }

        [Range(0, 100, ErrorMessage = "Percent must be between 0 and 100")]
        public float intex { get; set; }
    }
}
