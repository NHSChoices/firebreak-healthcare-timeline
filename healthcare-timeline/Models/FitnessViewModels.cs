using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace healthcare_timeline.Models
{
    public class FitnessDataViewModel
    {

        [Display(Name = "Height")]
        public float Height { get; set; }

        [Display(Name = "Weight")]
        public float Weight { get; set; }

        [Display(Name = "WeightDate")]
        public DateTime WeightDate { get; set; }

        [Display(Name = "DailySteps")]
        public int DailySteps { get; set; }

        [Display(Name = "DailyStepsDate")]
        public DateTime DailyStepsDate { get; set; }

        [Display(Name = "BMI")]
        public float BMI { get; set; }

        [Display(Name = "BMIDate")]
        public DateTime BMIDate { get; set; }

    }
}

    