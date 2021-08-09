#pragma checksum "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b84e49ef376928910bcc909d2a5539e1e47b76d"
// <auto-generated/>
#pragma warning disable 1591
namespace FontesBank.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using FontesBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\_Imports.razor"
using FontesBank.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
using FontesBank.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers")]
    public partial class Customers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Customers</h3>\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-8");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">E-mail</th>
                <th scope=""col"">Current Balance</th>
                <th scope=""col"">Select</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 26 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
             foreach (var ctm in users)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
                     ctm.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
                     ctm.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
                     ctm.CurrentBalance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
                                                                            () => Details(ctm.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                        Select\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 38 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projetos\fontesBank\fontes-Bank\FontesBank\FontesBank\Pages\Customers.razor"
       

    List<UserModel> users;

    protected override async Task OnInitializedAsync()
    {
        users = await _user.GetUsers();
    }


    private void Details(int id)
    {
        NavigationManager.NavigateTo("customers/" + id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _user { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
