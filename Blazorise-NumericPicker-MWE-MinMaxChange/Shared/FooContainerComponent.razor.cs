using Microsoft.AspNetCore.Components;

namespace Blazorise_NumericPicker_MWE_MinMaxChange.Shared;

public partial class FooContainerComponent {

    [Parameter]
    public FooContainer Data { get; set; }

    public IList<ContainerKind> ContainerKinds { get; } = Enum.GetValues<ContainerKind>();

    public int Minimum { get; set; }
    public int Maximum { get; set; }

    protected override void OnParametersSet() {
        EnsureLimitsAreSet();
        Console.WriteLine("Min & max set");
        base.OnParametersSet();
    }

    private void EnsureLimitsAreSet() {
        switch( Data.Kind ) {
            case ContainerKind.Normal:
                Minimum = 1;
                Maximum = 5;
                break;
            case ContainerKind.Special:
                Minimum = 10;
                Maximum = 100;
                break;
            case ContainerKind.SuperSpecial:
                Minimum = 6;
                Maximum = 1000;
                break;
            default:
                Minimum = Maximum = 0;
                break;
        }
    }

    private async Task KindChanged(ContainerKind kind) {
        Data.Kind = kind;
        EnsureLimitsAreSet();

        //await InvokeAsync(StateHasChanged);
    }
}
