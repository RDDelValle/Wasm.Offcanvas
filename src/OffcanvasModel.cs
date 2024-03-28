namespace Wasm.Offcanvas;

public class OffcanvasModel(Type childContentType, OffcanvasPosition position, string title)
{
    public Type ChildContentType { get; } = childContentType;
    public OffcanvasPosition Position { get; } = position;
    public string Title { get; } = title;
}