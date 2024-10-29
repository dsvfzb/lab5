using System;
using System.Collections.Generic;

namespace FreelancerManagement
{
    public class MobileDevelopmentProject : Project, ITaskable, ICalculable
    {
        private List<string> tasks;

        public MobileDevelopmentProject(string title, int estimatedHours)
            : base(title, estimatedHours)
        {
            tasks = new List<string>();
        }

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public decimal CalculateCost(decimal rate)
        {
            return EstimatedHours * rate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Mobile Development Project: {Title}");
            Console.WriteLine($"Estimated Hours: {EstimatedHours}");
            Console.WriteLine("Tasks:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"- {task}");
            }
        }
    }
}
