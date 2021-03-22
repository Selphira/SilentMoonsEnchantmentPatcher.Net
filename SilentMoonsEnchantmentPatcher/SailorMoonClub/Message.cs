// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class SailorMoonClub
    {
        public static class Message
        {
            private static FormLink<IMessageGetter> Construct(uint id) => new FormLink<IMessageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMessageGetter> SMC_ClaimMessage => Construct(0x6e305);
            public static FormLink<IMessageGetter> SMC_PlaceSwordMessage => Construct(0xbe5c);
            public static FormLink<IMessageGetter> NoMoonPearl => Construct(0xa8c1);
            public static FormLink<IMessageGetter> SMC_NoClaim => Construct(0x6e304);
        }
    }
}
