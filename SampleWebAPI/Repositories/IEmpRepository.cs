using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using SampleWebAPI.Controllers;

namespace SampleWebAPI.Repositories
{
   public  interface IEmpRepository
    {
        public void AddEmployee(EmpDetails emp);
        public void UpdateEmployee(EmpDetails emp);
        EmpDetails GetEmployee(string id);

        public void DeleteEmployee(string id);
    }
}