﻿using System;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IBrandService
	{
		CreatedBrandResponse Add(CreateBrandRequest brand);
		List<GetAllBrandResponse> GetAll();
	}
}

//resposes and requests