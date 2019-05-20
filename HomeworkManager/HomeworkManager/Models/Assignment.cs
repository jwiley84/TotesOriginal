using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkManager.Models
{
    public class Assignment
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public string Notes { get; set; }

        public bool IsFinished { get; set; }
    }
}
