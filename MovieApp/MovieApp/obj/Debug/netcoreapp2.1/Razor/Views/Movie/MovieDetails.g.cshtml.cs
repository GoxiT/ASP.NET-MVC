#pragma checksum "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\Movie\MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e14870982734d30e1b4533d12ef445302a6c9d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MovieDetails), @"mvc.1.0.view", @"/Views/Movie/MovieDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/MovieDetails.cshtml", typeof(AspNetCore.Views_Movie_MovieDetails))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\_ViewImports.cshtml"
using MovieApp;

#line default
#line hidden
#line 2 "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14870982734d30e1b4533d12ef445302a6c9d26", @"/Views/Movie/MovieDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0301d5cca4a9345895d039cc67d16e7b77f0437f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MovieDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\Movie\MovieDetails.cshtml"
  
    ViewData["Title"] = "MovieDetails";

#line default
#line hidden
            BeginContext(67, 41, true);
            WriteLiteral("\r\n<h2>MovieDetails</h2>\r\n\r\n<div>\r\n    <p>");
            EndContext();
            BeginContext(109, 10, false);
#line 9 "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\Movie\MovieDetails.cshtml"
  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(119, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(133, 11, false);
#line 10 "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\Movie\MovieDetails.cshtml"
  Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(144, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(158, 12, false);
#line 11 "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\Movie\MovieDetails.cshtml"
  Write(Model.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(170, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(184, 12, false);
#line 12 "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\Movie\MovieDetails.cshtml"
  Write(Model.Length);

#line default
#line hidden
            EndContext();
            BeginContext(196, 10, true);
            WriteLiteral("</p>\r\n    ");
            EndContext();
            BeginContext(207, 43, false);
#line 13 "C:\Users\Goran\Desktop\SEDC ACADEMY\MVC\MovieApp\MovieApp\Views\Movie\MovieDetails.cshtml"
Write(Html.ActionLink("Back To Movies", "Movies"));

#line default
#line hidden
            EndContext();
            BeginContext(250, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
