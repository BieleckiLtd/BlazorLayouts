using BlazorLayouts.Utilities;
using Microsoft.AspNetCore.Components;

namespace BlazorLayouts;

public partial class StackPanel
{
    private string? InternalClass => new CssBuilder("bl-stack-panel")
        .AddClass("bl-column", when: Orientation == Orientation.Vertical)

        .AddClass("bl-scrollbar-x-none", when: HorizontalScrollBar == ScrollBar.None)
        .AddClass("bl-scrollbar-x-overlay", when: HorizontalScrollBar == ScrollBar.Overlay)
        .AddClass("bl-scrollbar-x-always", when: HorizontalScrollBar == ScrollBar.Always)
        .AddClass("bl-scrollbar-y-none", when: VerticalScrollBar == ScrollBar.None)
        .AddClass("bl-scrollbar-y-overlay", when: VerticalScrollBar == ScrollBar.Overlay)
        .AddClass("bl-scrollbar-y-always", when: VerticalScrollBar == ScrollBar.Always)

        .AddClass("bl-wrap", when: IsWrapping)

        .AddClass("bl-justify-start", when: Justify == Justify.Start)
        .AddClass("bl-justify-center", when: Justify == Justify.Center)
        .AddClass("bl-justify-end", when: Justify == Justify.End)
        .AddClass("bl-justify-space-around", when: Justify == Justify.SpaceAround)
        .AddClass("bl-justify-space-between", when: Justify == Justify.SpaceBetween)
        .AddClass("bl-justify-space-evenly", when: Justify == Justify.SpaceEvenly)

        .AddClass("bl-align-start", when: Align == Align.Start)
        .AddClass("bl-align-center", when: Align == Align.Center)
        .AddClass("bl-align-end", when: Align == Align.End)
        .AddClass("bl-align-stretch", when: Align == Align.Stretch)
        .AddClass("bl-align-baseline", when: Align == Align.Baseline)

        .AddClass("bl-stretch-first-child", when: StretchChildren == StretchChildren.FirstChild)
        .AddClass("bl-stretch-last-child", when: StretchChildren == StretchChildren.LastChild)
        .AddClass("bl-stretch-middle-children", when: StretchChildren == StretchChildren.MiddleChildren)
        .AddClass("bl-stretch-all-children", when: StretchChildren == StretchChildren.AllChildren)

        .AddClass("bl-collapsed", when: !IsVisible && HidingMode == HidingMode.Collapse)
        .AddClass("bl-hidden", when: !IsVisible && HidingMode == HidingMode.Hide)

        .AddClass("bl-disabled", when: !IsEnabled)

        .AddClass("bl-animation", when: IsAnimatingChildrenStretching)
        .AddClass(Class)
        .Build();
    private string? InternalStyle => new CssBuilder()
        .AddClass($"margin: {MarginFinal};", when: Margin is not null)
        .AddClass($"padding: {PaddingFinal};", when: Padding is not null)
        .AddClass($"gap: {SpacingFinal};", when: Spacing is not null)
        .AddClass($"background: {Background};", when: Background is not null)
        .AddClass(Style)
        .Build();

    /// <summary>
    /// Defines whether child elements will be placed horizontally in a row instead or vertically in a column (default).
    /// Default: Orientation.Vertical
    /// </summary>
    [Parameter]
    public Orientation Orientation { get; set; } = Orientation.Vertical;

    /// <summary>
    /// Default: Justify.Normal
    /// </summary>
    [Parameter]
    public Justify Justify { get; set; } = Justify.Normal;

    /// <summary>
    /// Default: Align.Normal
    /// </summary>
    [Parameter]
    public Align Align { get; set; } = Align.Normal;

    /// <summary>
    /// Defines stretching the StackPanel's children on the main axis.
    /// If there is only one child, StretchChildren.FirstChild and
    /// StretchChildren.LastChild will have the same effect and the child will be stretched.
    /// StretchChildren.MiddleChildren will stretch all children except the first and last child.
    /// If there are two or fewer elements StretchChildren.MiddleChildren will have no effect. <summary>
    /// Default: StretchChildren.None
    /// </summary>
    [Parameter]
    public StretchChildren StretchChildren { get; set; } = StretchChildren.None;

    /// <summary>
    /// Defines whether changing between different StretchChildren values should be animated.
    /// Default: true
    /// </summary>
    [Parameter]
    public bool IsAnimatingChildrenStretching { get; set; } = true;

    /// <summary>
    /// Distance between child elements. For example 10px, 1rem, 20%... If unit is ommited uniform px value is assumed on all edges.
    /// Default: null
    /// </summary>
    [Parameter]
    public string? Spacing { get; set; }
    private string? SpacingFinal => decimal.TryParse(Spacing, out var result) ? $"{result}px" : Spacing;


    /// <summary>
    /// If true child elements will wrap when they don't fit in StackPanel.
    /// Default: false
    /// </summary>
    [Parameter]
    public bool IsWrapping { get; set; } = false;
}