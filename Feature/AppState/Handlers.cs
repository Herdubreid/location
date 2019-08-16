using BlazorState;
using System.Threading;
using System.Threading.Tasks;

namespace Location.Feature.AppState
{
    public partial class AppState
    {
        public class AddressHandler : RequestHandler<AddressAction, AppState>
        {
            AppState AppState => Store.GetState<AppState>();
            public override Task<AppState> Handle(AddressAction aRequest, CancellationToken aCancellationToken)
            {
                AppState.Address = aRequest.Address;
                return Task.FromResult(AppState);
            }
            public AddressHandler(IStore store) : base(store) { }
        }
        public class ErrorHandler : RequestHandler<ErrorAction, AppState>
        {
            AppState AppState => Store.GetState<AppState>();
            public override Task<AppState> Handle(ErrorAction aRequest, CancellationToken aCancellationToken)
            {
                AppState.Error = aRequest.Error;
                return Task.FromResult(AppState);
            }
            public ErrorHandler(IStore store) : base(store) { }
        }
    }
}
