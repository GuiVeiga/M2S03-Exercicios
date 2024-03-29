﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAdministration.Core
{
    public class ActivityClass
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartedActivity { get; private set; }
        public DateTime FinishedActivity { get; set; }
        public StatusEnum Status { get; set; }
        public Employee Employee { get; set; }
        public List<Student> Student { get; set; }

        public ActivityClass(string name, string description, DateTime startedActivity)
        {
            Name = name;
            Description = description;
            StartedActivity = startedActivity;
            Status = (StatusEnum)1;
        }
    }
}
