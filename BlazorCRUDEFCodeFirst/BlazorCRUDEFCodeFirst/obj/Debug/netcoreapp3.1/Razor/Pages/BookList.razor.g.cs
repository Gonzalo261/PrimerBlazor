#pragma checksum "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93a9c8d951f2e4cca667a7ce406ba1036f41c68"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUDEFCodeFirst.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using BlazorCRUDEFCodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using BlazorCRUDEFCodeFirst.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class BookList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BookList</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Esta pàgina va a mostrar una lista de libros</p>\r\n \r\n");
            __builder.AddMarkupContent(2, "<div>\r\n    <a href=\"/bookDetails\"><i>Agregar Nuevo Libro</i></a>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
 if (books == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p><em>Cargando...</em></p>\r\n");
#nullable restore
#line 15 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
}
else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<tr>\r\n        <th>Titulo</th>\r\n        <th>Autor</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 23 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
     foreach (var book in books)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 26 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
                 book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 27 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
                 book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/bookDetails/" + (
#nullable restore
#line 29 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
                                       book.BookId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<i>Editar</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "/bookDelete/" + (
#nullable restore
#line 30 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
                                      book.BookId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<i>Eliminar</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 33 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 37 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookList.razor"
       
    public IEnumerable<Book> books { get; set; }
    public string Message { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            books = await BookService.GetAllBook();
        }
        catch (Exception e)
        {
            Message = e.Message;
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService BookService { get; set; }
    }
}
#pragma warning restore 1591
