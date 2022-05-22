using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Models;

namespace Day2_assi.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(2)]
        [UniqueName]
        public string Name { get; set; }

        [Range(minimum: 50, maximum: 100)]
        public string Degree { get; set; }
        //reduce than degree
        [Remote(action: "CheckDegree", controller: "Course",ErrorMessage = "MinDegree is greater than course degree")]
        public string MinDegree { get; set; }
      
        [ForeignKey("department")]
        public int Dept_ID { get; set; }
        public virtual ICollection<Instractor> Instractors { get; set; }
        public Department department { get; set; }

        internal Course Find()
        {
            throw new NotImplementedException();
        }
    }
}
