using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Lab9.DataAccess.Data
{
    public class Group
    {
        public int GroupId { get; set; }
        public string CourseName { get; set; }
        public DateTime Commence { get; set; }
        public decimal BasePrice { get; set; }
        // навигационное свойство
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
