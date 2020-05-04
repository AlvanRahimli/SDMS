using System;
using System.ComponentModel.DataAnnotations;

namespace SDMS.Models
{
    public class Score : EntityBase
    {
        [Range(0, 100)]
        public int ScoreOver100 { get; set; }
        public DateTime Date { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}