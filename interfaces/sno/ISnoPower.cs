namespace Turbo.Plugins
{
    public interface ISnoPower
    {
        uint Sno { get; }
        string Code { get; }

        string NameLocalized { get; }
        string NameEnglish { get; }

        string DescriptionLocalized { get; }
        string DescriptionEnglish { get; }

        string[] RuneNamesLocalized { get; }
        string[] RuneNamesEnglish { get; }

        int[] IconIndexes { get; set; }
        int[] ElementalDamageTypesByRune { get; }
        int[] WeaponDamageMultipliersByRune { get; }
        float[] DotSecondsByRune { get; }
        int[] ResourceCostsByRune { get; }

        SnoPowerIcon[] Icons { get; }
        uint NormalIconTextureId { get; }
    }
}