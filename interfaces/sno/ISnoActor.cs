namespace Turbo.Plugins
{
    public interface ISnoActor
    {
        uint Sno { get; }
        ActorKind Kind { get; }
        string Code { get; }

        string NameLocalized { get; }
        string NameEnglish { get; }

        bool IsStatic { get; }
        uint[] TextureMap { get; }
    }
}