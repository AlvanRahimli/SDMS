using System;

namespace SDMS.Models.Dtos
{
    public class DateModel
    {
        public Guid ForId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}