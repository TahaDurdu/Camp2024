

using Intro.Business;
using Intro.Entities;

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

foreach (var i in courses2)
{
    Console.WriteLine(i.Name);
}