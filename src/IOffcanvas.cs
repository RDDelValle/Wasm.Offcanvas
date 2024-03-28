namespace Wasm.Offcanvas;

public interface IOffcanvas
{
    Task CloseOffcanvasAsync(Type type);
}