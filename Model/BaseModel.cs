using System;

namespace Database.Model
{
    public class BaseModel
    {
        public DateTime ExamDate { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
    }
}
