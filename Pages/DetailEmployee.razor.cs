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
    public partial class DetailEmployee
    {
        [Parameter]
        public string id { get; set; }
       
        [Inject]
        public IEmployeeService EmployeeService{ get; set; }


        public Employee Employee { get; set; } = new Employee();

        public String Koordinat{get; set; }
        protected void Mouse_Move(MouseEventArgs e){
            Koordinat = $"X = {e.ClientX}, Y = {e.ClientY}";
        }

        public string ButtonText { get; set; } ="Hide Footer";

        public string CssClass { get; set; } = null;

        protected void Button_Click(){
            if(ButtonText == "Hide Footer"){
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else{
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Employee = await EmployeeService.GetById(int.Parse(id));
        }
    }
}