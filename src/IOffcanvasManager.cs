using Microsoft.AspNetCore.Components;

namespace Wasm.Offcanvas;

public interface IOffcanvasManager
{
    event EventHandler<CreateOffcanvasEventArgs> OnCreateOffcanvas;
    ValueTask CreateOffcanvasAsync<T>(OffcanvasPosition position, string title) where T : IComponent;
}