#pragma checksum "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e24f87ef61528cce36b0df119c5e9049eae943"
// <auto-generated/>
#pragma warning disable 1591
namespace PackagesManagementBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using PackagesManagementBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\_Imports.razor"
using PackagesManagementBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
using PackagesManagementBlazor.Client.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
using PackagesManagementBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
using PackagesManagementBlazor.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Search packages by location</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                 search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                         Search

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label for=\"integerfixed\">Insert location starting chars</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                                search.Location

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => search.Location = __value, search.Location))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => search.Location));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __Blazor.PackagesManagementBlazor.Client.Pages.Index.TypeInference.CreateValidationMessage_0(__builder2, 15, 16, 
#nullable restore
#line 14 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                                  () => search.Location

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.AddMarkupContent(18, "<button type=\"submit\" class=\"btn btn-primary\">\r\n        Search\r\n    </button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 20 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
 if (packages != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "table-responsive");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table");
            __builder.AddMarkupContent(23, @"<thead><tr><th scope=""col"">Destination</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Duration/days</th>
                    <th scope=""col"">Price</th>
                    <th scope=""col"">Availble from</th>
                    <th scope=""col"">Availble to</th></tr></thead>
            ");
            __builder.OpenElement(24, "tbody");
#nullable restore
#line 37 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                 foreach (var package in packages)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 41 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                             package.DestinationName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 44 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                             package.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 47 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                             package.DuratioInDays

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 50 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                             package.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 53 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                              package.StartValidityDate.HasValue ?
                                package.StartValidityDate.Value.ToString("d")
                                :
                                String.Empty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 59 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                              package.EndValidityDate.HasValue ?
                                package.EndValidityDate.Value.ToString("d")
                                :
                                String.Empty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
}
else if (loading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<p><em>Loading...</em></p>");
#nullable restore
#line 74 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\HP\Documents\New Book\Code\PackagesManagementBlazor\PackagesManagementBlazor\Client\Pages\Index.razor"
      
    SearchViewModel search { get; set; } = new SearchViewModel();
    private IEnumerable<PackageInfosViewModel> packages;
    bool loading;
    async Task Search()
    {
        packages = null;
        loading = true;
        await InvokeAsync(StateHasChanged);
        packages = await client.GetByLocation(search.Location);
        loading = false;
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PackagesClient client { get; set; }
    }
}
namespace __Blazor.PackagesManagementBlazor.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
