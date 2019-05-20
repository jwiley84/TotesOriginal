using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkManager.Models
{
    public class Project
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Notes { get; set; }

        public bool IsFinished { get; set; }

        public string TestingDueDate { get; set; }

        // uncomment for prod
        //public DateTime DueDate { get; set; }

        // This one is a bit dicey
        //public List<Assignment> ShortTasks { get; set; }


    }
}
