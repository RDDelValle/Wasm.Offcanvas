using Microsoft.AspNetCore.Components;

namespace Wasm.Offcanvas;

internal class OffcanvasManager : IOffcanvasManager
{
    
    private EventHandler<CreateOffcanvasEventArgs>? _onCreateOffcanvas;
    public event EventHandler<CreateOffcanvasEventArgs> OnCreateOffcanvas
    {
        add => _onCreateOffcanvas += value;
        remove => _onCreateOffcanvas -= value;
    }
    
    public ValueTask CreateOffcanvasAsync<T>(OffcanvasPosition position, string title) where T: IComponent
    {
        _onCreateOffcanvas?.Invoke(this, new CreateOffcanvasEventArgs(new OffcanvasModel(typeof(T), position, title)));
        return ValueTask.CompletedTask;
    }
    
}