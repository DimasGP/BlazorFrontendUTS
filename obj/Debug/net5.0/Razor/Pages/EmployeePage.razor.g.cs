#pragma checksum "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "996ec3d668d9e34a1f75edb7bec3bc0c7f1f4614"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFrontendUTS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using BlazorFrontendUTS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dimas\Front end\BlazorFrontendUTS\_Imports.razor"
using BlazorFrontendUTS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeepage")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Daftar Department</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><th>Employee Id</th>\r\n            <th>Firt Name</th>\r\n            <th>Last Name</th>\r\n            <th>Email</th>\r\n             <th>Keterangan Detail</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 17 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\EmployeePage.razor"
         foreach(var dept in Employees){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 19 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\EmployeePage.razor"
                     dept.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 20 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\EmployeePage.razor"
                     dept.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 21 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\EmployeePage.razor"
                     dept.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 22 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\EmployeePage.razor"
                     dept.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 23 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\EmployeePage.razor"
                               $"employeedetail/{dept.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddContent(22, "detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Dimas\Front end\BlazorFrontendUTS\Pages\EmployeePage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
