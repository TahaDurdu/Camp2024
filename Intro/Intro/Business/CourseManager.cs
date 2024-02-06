﻿using System;
using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses=new Course[3];

    public CourseManager()
	{

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
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

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;

    }
	public Course[] GetAll()
	{
        return courses;
	}
  
}

