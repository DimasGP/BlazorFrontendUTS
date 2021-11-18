using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontendUTS.Models;
using BlazorFrontendUTS.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorFrontendUTS.Pages
{
    public partial class EmployeeDtl
    {
        public IEnumerable<Employee> Employees {get; set; }
        
        [Inject]
        public IEmployeeService EmployeeService{ get; set; }

        public String Koordinat{get; set; }
        protected void Mouse_Move(MouseEventArgs e){
            Koordinat = $"X = {e.ClientX}, Y = {e.ClientY}";
        }

         protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}