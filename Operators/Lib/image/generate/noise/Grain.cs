namespace Lib.image.generate.noise;

[Guid("b5102fba-f05b-43fc-aa1d-613fe1d68ad2")]
internal sealed class Grain : Instance<Grain>
{
    [Output(Guid = "df388f27-f5b6-417b-87a7-a6a59b625128")]
    public readonly Slot<Texture2D> TextureOutput = new();


    [Input(Guid = "4525c76c-cdcf-47f3-aa96-335cfc5b5c1b")]
    public readonly InputSlot<Texture2D> Image = new();

    [Input(Guid = "195da7e0-5279-4900-80cd-5635e96ab454")]
    public readonly InputSlot<float> Amount = new();

    [Input(Guid = "903c0270-dc46-402e-8088-8db8368a6dfb")]
    public readonly InputSlot<float> Color = new();

    [Input(Guid = "d24cce46-dd3f-4047-a33f-50abbca89cc4")]
    public readonly InputSlot<float> Exponent = new();

    [Input(Guid = "87a78859-5f0c-41af-8564-ac691b8f1950")]
    public readonly InputSlot<float> Brightness = new();

    [Input(Guid = "f1334f45-4335-4198-9b6e-ab9e8384aa32")]
    public readonly InputSlot<float> Speed = new();

    [Input(Guid = "edb719cd-be40-4758-9c13-98cf14d1a5c5")]
    public readonly InputSlot<float> Scale = new();

    [Input(Guid = "61bb0df6-6c8a-4f3a-b7f4-9d979377cab8")]
    public readonly InputSlot<Int2> Resolution = new();

    [Input(Guid = "74ca5916-20ee-4a1f-a41e-342c12d2126a")]
    public readonly InputSlot<bool> GenerateMipmaps = new();
}