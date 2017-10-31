using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class CourseRepository
    {
        private List<Course> courses { get; set; } = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course GetCourse(string itemId)
        {
            foreach (var c in courses)
            {
                if (c.ItemId == itemId)
                    return c;
            }
            return null;
        }
        public double GetTotalValue()
        {
            double totalValue = 0.0;

            foreach(var c in courses)
            {
                totalValue += Utility.GetValueOfCourse(c);
            }

            return totalValue;
        }
    }
}
