using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CohensCigars.Models
{
    public class CatalogData
    {
        public int ID { get; set; }

        [Display(Name = "Name:")]
        public string ProductName { get; set; }

        [Display(Name = "Price:")]
        public Double PricePerUnit { get; set; }

        public uint Stock { get; set; }

        [Display(Name = "In Stock:")]
        public bool InStock { get; set; }

        [Display(Name = "Country of Origin:")]
        public string Origin { get; set; }

        [Display(Name = "Description:")]
        public string Description { get; set; }

        public string ImageString { get; set; }

        [Display(Name = "Price Level:")]
        public PriceLevel PriceLevel { get; set; }

        [Display(Name = "Quality Level:")]
        public QualityLevel QualityLevel { get; set; }
    }

    public enum PriceLevel
    {
        Low,
        Medium,
        High
    }

    public enum QualityLevel
    {
        Average,
        Good,
        VeryGood,
        Excellent,
        TheBest
    }
}