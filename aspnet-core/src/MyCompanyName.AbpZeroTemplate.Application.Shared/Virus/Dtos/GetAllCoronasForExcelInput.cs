﻿using Abp.Application.Services.Dto;
using System;

namespace MyCompanyName.AbpZeroTemplate.Virus.Dtos
{
    public class GetAllCoronasForExcelInput
    {
		public string Filter { get; set; }

		public string NameFilter { get; set; }

		public string SymptomFilter { get; set; }



    }
}