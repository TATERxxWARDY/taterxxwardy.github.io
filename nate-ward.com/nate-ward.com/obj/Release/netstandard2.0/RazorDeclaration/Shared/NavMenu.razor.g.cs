#pragma checksum "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30e77501f991ca7d57e05376184239d43bb5ad1b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace nate_ward.com.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\_Imports.razor"
using nate_ward.com;

#line default
#line hidden
#line 7 "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\_Imports.razor"
using nate_ward.com.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "C:\Sites\taterxxwardy.github.io\nate-ward.com\nate-ward.com\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
