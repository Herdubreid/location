using Location.Data;
using MediatR;

namespace Location.Feature.AppState
{
    public class AddressAction : IRequest<AppState>
    {
        public Address Address { get; set; }
    }
    public class ErrorAction : IRequest<AppState>
    {
        public string Error { get; set; }
    }
}
