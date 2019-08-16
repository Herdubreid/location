using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using BlazorState;
using MediatR;
using Location.Feature.AppState;

namespace Location.Data
{
    public class LocationService
    {
        IMediator Mediator { get; }
        IJSRuntime JS { get; }
        string BingKey { get; }
        public static object Lock = new object();
        public DotNetObjectRef<LocationService> Ref { get; }
        [JSInvokable]
        public void Location(Address address)
        {
            Mediator.Send(new AddressAction { Address = address });
        }
        [JSInvokable]
        public void Error(string error)
        {
            Mediator.Send(new ErrorAction { Error = error });
        }
        async public Task LoadMap()
        {
            await JS.InvokeAsync<object>("LoadMap", BingKey, Ref);
        }
        public LocationService(IMediator mediator, IConfiguration configuration, IJSRuntime jsRuntime)
        {
            Mediator = mediator;
            BingKey = configuration["bing"];
            JS = jsRuntime;
            lock (Lock)
            {
                JSRuntime.SetCurrentJSRuntime(jsRuntime);
                Ref = DotNetObjectRef.Create(this);
            }
        }
    }
}
