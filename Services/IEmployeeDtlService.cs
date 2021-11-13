using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontendUTS.Models;

namespace BlazorFrontendUTS.Services
{
    public interface IEmployeeDtlService
    {
        
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetById(int id);
    }
}