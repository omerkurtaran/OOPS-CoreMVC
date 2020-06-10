﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class AdvanceDTO
    {
        public int Sum { get; set; }
        public DateTime Date { get; set; }
        public string Installment { get; set; }
        public string Description { get; set; }
        public virtual List<EmployeeAdvanceDTO> EmployeeAdvances { get; set; }
    }
}
