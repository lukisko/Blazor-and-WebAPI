#pragma checksum "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "118300bafe9721eba2bed91a1e4f4e13c9f719ff"
// <auto-generated/>
#pragma warning disable 1591
namespace assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/_Imports.razor"
using assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
using assignment.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/List")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Adults</h1>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "color:red");
            __builder.AddContent(3, 
#nullable restore
#line 8 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                        errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "filter user by name: ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                                                      (arg)=> FilterByFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
 if (adults == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<p>loading</p>");
#nullable restore
#line 12 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
} else if (!adults.Any()){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p>No adults in system.</p>");
#nullable restore
#line 14 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "<thead><th>Id:</th>\n            <th>First name</th>\n            <th>Last name</th>\n            <th>Age:</th>\n            <th>Weight:</th>\n            <th>Sex:</th>\n            <th>Job title</th>\n            <th>Salary:</th></thead>\n        ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 27 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
             foreach (var item in adults)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                         item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                         item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                         item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 33 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                         item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 34 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                         item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 35 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                         item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 36 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                         item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 37 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                         item.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(41);
            __builder.AddAttribute(42, "Policy", "SecurityLevel4");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(44, "td");
                __builder2.OpenElement(45, "button");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
                                               () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(47, "<i class=\"oi oi-trash\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 46 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment2/RazorWebpage/Pages/AdultList.razor"
      
    //nothing
    private IList<Adult> adults;

    private string errorMessage;
    protected override async Task OnInitializedAsync()
    {
        var tmpAdults = await AdultData.GetAdults();
        Console.WriteLine(tmpAdults.ToString());
        adults = tmpAdults;
    }

    private async void RemoveAdult(int adultID){
        Adult toRemove = adults.First(adult => adult.Id == adultID);
        try {
            await AdultData.RemoveAdult(toRemove.Id);
        } catch (Exception e){
            errorMessage = e.Message;
        }
        
        adults.Remove(toRemove);
    }

    private async void FilterByFirstName(ChangeEventArgs EventFirstName){
        string searchName = EventFirstName.Value.ToString();
        
        if (searchName == ""){
            adults = await AdultData.GetAdults();
        } else {
            var tempawait = await AdultData.GetAdults();
            adults = tempawait.Where((adul) => {
                string fullName = adul.FirstName + " " + adul.LastName;
                return fullName.Contains(searchName);
            }).ToList();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
