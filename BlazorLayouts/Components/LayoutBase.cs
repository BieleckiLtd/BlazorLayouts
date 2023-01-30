using Microsoft.AspNetCore.Components;

namespace BlazorLayouts;

public abstract class LayoutBase : ComponentBase
{
    /// <summary>
    /// Default: null
    /// </summary>
    [Parameter]
    public string? Class { get; set; }

    /// <summary>
    /// Default: null
    /// </summary>
    [Parameter]
    public string? Style { get; set; }

    /// <summary>
    /// Space around the panel. For example 10px, 1rem, 20%... If unit is ommited uniform px value is assumed on all edges.
    /// Default: null
    /// </summary>
    [Parameter]
    public string? Margin { get; set; }
    internal string? MarginFinal => decimal.TryParse(Margin, out var result) ? $"{result}px" : Margin;

    /// <summary>
    /// Space around the panel's content. For example 10px, 1rem, 20%... If unit is ommited uniform px value is assumed on all edges.
    /// Default: null
    /// </summary>
    [Parameter]
    public string? Padding { get; set; }
    internal string? PaddingFinal => decimal.TryParse(Padding, out var result) ? $"{result}px" : Padding;

    /// <summary>
    /// Default: null
    /// </summary>
    [Parameter]
    public string? Background { get; set; }

    /// <summary>
    /// Default: true
    /// </summary>
    [Parameter]
    public bool IsVisible { get; set; } = true;

    /// <summary>
    /// Default: HidingMode.Collapse
    /// </summary>
    [Parameter]
    public HidingMode HidingMode { get; set; } = HidingMode.Collapse;

    /// <summary>
    /// Default: true
    /// </summary>
    [Parameter]
    public bool IsEnabled { get; set; } = true;

    /// <summary>
    /// Gets or sets a value that indicates whether a vertical ScrollBar should be displayed.
    /// Default: ScrollBar.Auto
    /// </summary>
    [Parameter]
    public ScrollBar VerticalScrollBar { get; set; } = ScrollBar.Auto;

    /// <summary>
    /// Gets or sets a value that indicates whether a horizontal ScrollBar should be displayed.
    /// Default: ScrollBar.Auto
    /// </summary>
    [Parameter]
    public ScrollBar HorizontalScrollBar { get; set; } = ScrollBar.Auto;

    /// <summary>
    /// UserAttributes carries all attributes you add to the component that don't match any of its parameters.
    /// They will be splatted onto the underlying HTML tag.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> Attributes { get; set; } = new();

    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}