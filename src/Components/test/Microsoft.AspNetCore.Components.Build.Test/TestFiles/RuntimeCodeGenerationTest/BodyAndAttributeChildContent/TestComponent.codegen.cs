// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
   RenderFragment<string> header = (context) => 

#line default
#line hidden
            (builder2) => {
                builder2.OpenElement(0, "div");
                builder2.AddContent(1, context.ToLowerInvariant());
                builder2.CloseElement();
            }
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                       ; 

#line default
#line hidden
            builder.OpenComponent<Test.MyComponent>(2);
            builder.AddAttribute(3, "Header", new Microsoft.AspNetCore.Components.RenderFragment<System.String>(header));
            builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddContent(5, "\n    Some Content\n");
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
