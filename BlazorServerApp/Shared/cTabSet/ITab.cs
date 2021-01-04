using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Shared.cTabSet
{
    public interface ITab
    {
        RenderFragment ChildContent {get;}
    }

}