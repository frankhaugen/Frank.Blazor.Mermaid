using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Frank.Blazor.Mermaid;

internal class MermaidInterop
{
    private const string MermaidJsFilename = "mermaid.min.js";
    private const string MermaidJsFilename = "mermaid.min.js";
    private readonly IJSRuntime _jsRuntime;
    private IJSObjectReference? _module;
    

    public MermaidInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }
    
    private bool IsInitialized => _module != null;

    public async Task Initialize()
    {
        await InitializeMermaid();
    }

    public async Task Render(string id, string definition)
    {
        await InitializeMermaid();
        await _jsRuntime.InvokeVoidAsync("mermaid.render", id, definition);
    }

    private async Task InitializeMermaid()
    {
        if (IsInitialized)
            return;

        await InitializeMermaidModuleAsync();
        
        await _module!.InvokeVoidAsync("initialize", new { startOnLoad = true });
    }
    
    
    private async Task InitializeMermaidModuleAsync() =>
        _module = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", $"./_content/Frank.Blazor.Mermaid/{MermaidJsFilename}");

}