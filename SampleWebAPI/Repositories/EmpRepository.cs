using SampleWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAPI.Repositories
{
 
    public class EmpRepository : IEmpRepository
    {
        private readonly EmployeedbContext _context;
        public EmpRepository(EmployeedbContext context)
        {
            _context = context;
        }
        public void AddEmployee(EmpDetails emp)
        {
            _context.EmpDetails.Add(emp);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            EmpDetails e = _context.EmpDetails.Find(id);
            _context.Remove(e);
            _context.SaveChanges();
        }

        public EmpDetails GetEmployee(int id)
        {
            return _context.EmpDetails.Find(id);
        }

        public void UpdateEmployee(EmpDetails emp)
        {
            _context.Update(emp);
        }
    }