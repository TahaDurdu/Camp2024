﻿using Intro.DataAccess.Abstract;
using Intro.Entities;

namespace Intro.DataAccess.Concretes
{
    public class EfCourseDal:ICourseDal
    {
        List<Course> courses;

        public EfCourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "JavaScript";
            course1.Description = ".Net 8";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "java 17 ..";
            course2.Price = 10;

            Course course3 = new Course();
            course2.Id = 3;
            course2.Name = "Python";
            course2.Description = "python 1 .2.3";
            course2.Price = 5;

            courses = new List<Course> { course1, course2, course3 };
        }
        public List<Course> GetAll()
        {
            //Burada Db işlemleri Yapılır
            return courses;

        }
        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}
