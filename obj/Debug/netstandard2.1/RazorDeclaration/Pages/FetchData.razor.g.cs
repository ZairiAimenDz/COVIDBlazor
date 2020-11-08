#pragma checksum "/home/zairi/Projects/CovidBlazor/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be5d5a146ae1d44f871fed1e10094e4b2e7a196"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CovidBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using CovidBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/zairi/Projects/CovidBlazor/_Imports.razor"
using CovidBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/home/zairi/Projects/CovidBlazor/Pages/FetchData.razor"
       
    private Root all;

    protected override async Task OnInitializedAsync()
    {
        string url = "https://api.covid19api.com/summary";
        try{
        using (var client = new HttpClient())
            {
                Uri uri = new Uri(string.Format(url, string.Empty));
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    all = JsonConvert.DeserializeObject<Root>(content);
                }
            }
        }catch{
            Console.WriteLine("Error");
        }
    }

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Global    {
        public int NewConfirmed { get; set; } 
        public int TotalConfirmed { get; set; } 
        public int NewDeaths { get; set; } 
        public int TotalDeaths { get; set; } 
        public int NewRecovered { get; set; } 
        public int TotalRecovered { get; set; } 
    }

    public class Premium    {
    }

    public class Countrys    {
        public string Country { get; set; } 
        public string CountryCode { get; set; } 
        public string Slug { get; set; } 
        public int NewConfirmed { get; set; } 
        public int TotalConfirmed { get; set; } 
        public int NewDeaths { get; set; } 
        public int TotalDeaths { get; set; } 
        public int NewRecovered { get; set; } 
        public int TotalRecovered { get; set; } 
        public DateTime Date { get; set; } 
        public Premium Premium { get; set; } 
    }

    public class Root    {
        public string Message { get; set; } 
        public Global Global { get; set; } 
        public List<Countrys> Countries { get; set; } 
        public DateTime Date { get; set; } 
    }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
