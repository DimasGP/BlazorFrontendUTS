using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontendUTS.Models;

namespace BlazorFrontendUTS.Services
{
    public interface IEmployeeService
    {
        
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Update(int id,Employee employee);
        
    }
}