using System;
using Intro.DataAccess.Abstract;
using Intro.DataAccess.Concretes;
using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
	ICourseDal _courseDal;

	 public CourseManager(ICourseDal courseDal)
	{
		_courseDal = courseDal;
	}

	public List<Course> GetAll()
	{
		//business rules


        return _courseDal.GetAll();
	}

  
}

