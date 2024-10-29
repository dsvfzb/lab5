using System;

namespace FreelancerManagement
{
    public abstract class Project
    {
        public string Title { get; set; }
        public int EstimatedHours { get; set; }

        public Project(string title, int estimatedHours)
        {
            Title = title;
            EstimatedHours = estimatedHours;
        }

        public abstract void DisplayInfo();
    }
}
