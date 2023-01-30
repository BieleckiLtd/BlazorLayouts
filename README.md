# BlazorLayouts
Layout panels for use in Blazor

# Install
1. Add package reference (.NET CLI):

   `dotnet add package BlazorLayouts --version 1.0.0`

2. In project (Blazor Server):

   In `_Host.cshtml`, `<head></head>` section add: `<link href="_content/BlazorLayouts/blazor-layouts.css" rel="stylesheet"/>`
   
# Use
```razor
<StackPanel Orientation="Orientation.Vertical" 
            Justify="Justify.Normal"
            Align="Align.Normal"
            StretchChildren="@stretchChildren"
            IsVisible="true"
            HidingMode="HidingMode.Collapse"
            IsEnabled="true"
            Margin="0"
            Padding="10"
            Spacing="10"
            HorizontalScrollBar="ScrollBar.Auto"
            VerticalScrollBar="ScrollBar.Auto"
            Style="height: 300px" Background="lightgray">
    <button class="btn btn-primary">One</button>
    <button class="btn btn-primary">Two</button>
    <button class="btn btn-primary">Three</button>
    <button class="btn btn-primary">Four</button>
    <button class="btn btn-primary">Five</button>
</StackPanel>
```
