namespace Blazorise_NumericPicker_MWE_MinMaxChange; 

public class FooContainer {
    public ContainerKind Kind { get; set; }

    public int Value { get; set; }
}

public enum ContainerKind {
    Normal,
    Special,
    SuperSpecial
}
