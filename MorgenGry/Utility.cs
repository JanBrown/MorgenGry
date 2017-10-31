using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public static class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public static double GetValueOfAmulet(Amulet amulet)
        {
            double amuletValue = 0.0f;

            switch (amulet.Quality)
            {
                case Level.low:
                    amuletValue = 12.5;
                    break;
                case Level.medium:
                    amuletValue = 20.0;
                    break;
                case Level.high:
                    amuletValue = 27.5;
                    break;
            }

            return amuletValue;
        }
        public static double GetValueOfCourse(Course course)
        {
            return 875.0 * (course.DurationInMinutes / 60);
        }
    }
}
