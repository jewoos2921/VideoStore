#pragma checksum "C:\Users\jewoo\source\repos\VideoStore\VideoStore\Pages\Videos\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc66fd16b16bd9db26cfebcaa28b3e82c63b3664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VideoStore.Pages.Videos.Pages_Videos_List), @"mvc.1.0.razor-page", @"/Pages/Videos/List.cshtml")]
namespace VideoStore.Pages.Videos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\jewoo\source\repos\VideoStore\VideoStore\Pages\_ViewImports.cshtml"
using VideoStore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc66fd16b16bd9db26cfebcaa28b3e82c63b3664", @"/Pages/Videos/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba374601133ed1bd7992ab2755d6bc7d7034f4b7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Videos_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\jewoo\source\repos\VideoStore\VideoStore\Pages\Videos\List.cshtml"
Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-4"">
            Title
        </div>
        <div class=""col-md-4"">
            Release Date
        </div>
        <div class=""col-md-4"">
            Genre
        </div>
    </div>
");
#nullable restore
#line 18 "C:\Users\jewoo\source\repos\VideoStore\VideoStore\Pages\Videos\List.cshtml"
     foreach (var video in Model.Videos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 22 "C:\Users\jewoo\source\repos\VideoStore\VideoStore\Pages\Videos\List.cshtml"
           Write(video.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 25 "C:\Users\jewoo\source\repos\VideoStore\VideoStore\Pages\Videos\List.cshtml"
           Write(video.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 28 "C:\Users\jewoo\source\repos\VideoStore\VideoStore\Pages\Videos\List.cshtml"
           Write(video.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\jewoo\source\repos\VideoStore\VideoStore\Pages\Videos\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoStore.Pages.Videos.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VideoStore.Pages.Videos.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VideoStore.Pages.Videos.ListModel>)PageContext?.ViewData;
        public VideoStore.Pages.Videos.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
