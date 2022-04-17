using Microsoft.JSInterop;
using System.IO;
using System.Threading.Tasks;

namespace BookStorePdf.Blazor.Pages;

public partial class Index
{
    private readonly IJSRuntime _jsRuntime;
    private readonly IPrintingAppService _printingAppService;
    private IJSObjectReference _jsModule;

    public Index(IJSRuntime jsRuntime, IPrintingAppService printingAppService)
    {
        _jsRuntime = jsRuntime;
        _printingAppService = printingAppService;
    }

    protected override async Task OnInitializedAsync()
    {
        _jsModule = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "./scripts/myscripts.js");
    }

    private async Task PrintTestAsync()
    {
        var result = await _printingAppService.PrintAsync();

        var fileName = "Test.pdf";

        using var fileStream = new MemoryStream(result);
        using var streamRef = new DotNetStreamReference(stream: fileStream);

        await _jsModule.InvokeVoidAsync("downloadFileFromStream", fileName, streamRef);
    }
}
