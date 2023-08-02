using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace upgraded_spork.Client.Pages;

public partial class Component
{
    private string sampleText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

    //MudTextField<string> _logWindow;

    private void _doubleWindowText()
    {
        sampleText = sampleText + "\n" + sampleText;

        InvokeAsync(() => ShowAlertWindow());
    }

    async Task TextChanged(string text)
    {
        //await _logWindow.SelectRangeAsync(text.Length - 2, text.Length - 1);
        StateHasChanged();
    }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    private IJSObjectReference _jsModule;

    public async Task ShowAlertWindow()
    {
        await _jsModule.InvokeVoidAsync("showAlert", "JS function called from .NET");
    }

    protected override async Task OnInitializedAsync()
    {
        _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./scripts/ScrollToBottom.js");
    }
}

