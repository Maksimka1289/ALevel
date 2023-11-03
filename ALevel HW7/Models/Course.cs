

using ALevel_HW7.Interfaces;

namespace ALevel_HW7.Models
{
    public class Course : IDisplayAble
    {
        private string CourseName { get; set; }
        private int CourseCode { get; set; }

        public Course(string courseName, int courseId)
        {
            CourseName = courseName;
            CourseCode = courseId;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}, Course Code: {CourseCode}");
        }
    }
}
