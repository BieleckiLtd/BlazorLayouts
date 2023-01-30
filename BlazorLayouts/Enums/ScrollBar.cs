namespace BlazorLayouts;
public enum ScrollBar
{
    /// <summary>
    /// A ScrollBar does not appear even when the viewport cannot display all of the content. Scrolling might be possible with a mouse wheel or a keyboard.
    /// </summary>
    None = 0,

    /// <summary>
    /// A ScrollBar appears on top of the content when the viewport cannot display all of the content.
    /// </summary>
    Overlay = 1,

    /// <summary>
    /// Operating system or user-agent decides when a ScrollBar should appear. Usually a ScrollBar is visible when the viewport cannot display all of the content.
    /// </summary>
    Auto = 2,

    /// <summary>
    /// A ScrollBar appears when the viewport cannot display all of the content. A ScrollBar always appears. This option might be overriden by the system or user-agent settings.
    /// </summary>
    Always = 3
}