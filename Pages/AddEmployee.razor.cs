using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontendUTS.Models;
using BlazorFrontendUTS.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFrontendUTS.Pages
{
    public partial class AddEmployee
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        

        protected async override Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetAll()).ToList();
        }

        protected async Task HandleValidSubmit()
        {
            Employee.Photopath = "images/nophoto.jpg";
            var result = await EmployeeService.Add(Employee);
            NavigationManager.NavigateTo("employeedtl"); 
        }
    }
}