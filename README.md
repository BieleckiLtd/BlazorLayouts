![logo](https://user-images.githubusercontent.com/57046415/215855661-120127a4-c1af-4d71-9f87-2ad9264b7f4d.png)

# Blazor Layouts
Layout panels for Blazor

# Install
1. Add package reference (.NET CLI):

   `dotnet add package BlazorLayouts --version 1.0.0`

2. In Blazor Server:

   In `_Host.cshtml`, `<head></head>` add: `<link href="_content/BlazorLayouts/blazor-layouts.css" rel="stylesheet"/>`
   
# Use

## StackPanel

Minimal example:
```razor
<StackPanel>
    <button>One</button>
    <button>Two</button>
    <button>Three</button>
    <button>Four</button>
    <button>Five</button>
</StackPanel>
```

Full example:
```razor
<StackPanel Orientation="Orientation.Vertical" 
            Justify="Justify.Normal"
            Align="Align.Normal"
            StretchChildren="StretchChildren.None"
            IsVisible="true"
            HidingMode="HidingMode.Collapse"
            IsEnabled="true"
            Margin="0"
            Padding="10"
            Spacing="10"
            HorizontalScrollBar="ScrollBar.Auto"
            VerticalScrollBar="ScrollBar.Auto"
            Style="height: 300px"
            Background="lightgray">
    <button>One</button>
    <button>Two</button>
    <button>Three</button>
    <button>Four</button>
    <button>Five</button>
</StackPanel>
```

