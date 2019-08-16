using BlazorState;
using Location.Data;

namespace Location.Feature.AppState
{
    public partial class AppState : State<AppState>
    {
        public Address Address { get; set; }
        public string Error { get; set; }
        protected override void Initialize() { }
    }
}
