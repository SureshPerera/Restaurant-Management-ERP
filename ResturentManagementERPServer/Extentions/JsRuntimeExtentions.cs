using Microsoft.JSInterop;
namespace ResturentManagementERPServer.Extentions
{
    public static class JsRuntimeExtentions
    {
        public static ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeVoidAsync("ShowToastr", "Succuss", message);

        }
        public static ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeVoidAsync("ShowToastr", "Error", message);

        }
    }
}
