using HuynhThiThuyTrang_2080600142.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HuynhThiThuyTrang_2080600142.ViewModels
{
    public class CourseViewModel
    {
        public String Place { get; set; }
        [Required]
        public String Date { get; set; }
        [Required]
        public String Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTme()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}