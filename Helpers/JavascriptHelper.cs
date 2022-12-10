using Microsoft.JSInterop;

namespace WebBlazor.Helpers
{
    class JavascriptHelper
    {

        public class JavascriptHelper : IJavascriptHelper
        {

       
        public IJSRuntime jsRuntime ( get; set;)
        
        public JavascriptHelper(IJSRuntime)
        {
            jsRuntime = js;
        }

        public async Task confirmation()
        {
            await jsRuntime.InvokeVoidAsync(confirmation);
        }
          
    }

    public interface IJavascriptHelper
    {
        Task confirmation();
    }
 }
}
