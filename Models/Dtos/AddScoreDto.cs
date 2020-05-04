using System;
using System.ComponentModel.DataAnnotations;

namespace SDMS.Models.Dtos
{
    public class AddScoreDto
    {
        [Range(0, 100)]
        public int ScoreOver100 { get; set; }
        public DateTime Date { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
    }
}