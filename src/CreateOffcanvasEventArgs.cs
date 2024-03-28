namespace Wasm.Offcanvas;

public class CreateOffcanvasEventArgs(OffcanvasModel model)
{
    public OffcanvasModel Model { get; } = model;
}