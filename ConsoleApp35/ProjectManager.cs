using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FreelancerManagement
{
    public class ProjectManager
    {
        private List<Project> projects = new List<Project>();

        public void AddProject(Project project)
        {
            projects.Add(project);
        }

        public void DisplayAllProjects()
        {
            for (int i = 0; i < projects.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {projects[i].Title}");
            }
        }

        public void DisplayProjectInfo(int index)
        {
            if (index >= 0 && index < projects.Count)
                projects[index].DisplayInfo();
            else
                Console.WriteLine("Invalid project number.");
        }

        public void SaveProjectsToFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Project>), new Type[] { typeof(WebDevelopmentProject), typeof(MobileDevelopmentProject) });
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, projects);
            }
        }

        public void LoadProjectsFromFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Project>), new Type[] { typeof(WebDevelopmentProject), typeof(MobileDevelopmentProject) });
            using (StreamReader reader = new StreamReader(filePath))
            {
                projects = (List<Project>)serializer.Deserialize(reader);
            }
        }
    }
}
