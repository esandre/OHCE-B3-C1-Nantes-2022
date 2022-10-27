namespace OHCE.Test.Utilities
{
    internal class HorlogeRéglable : IHorloge
    {
        public HorlogeRéglable(bool estPlusDe18H)
        {
            SommesNousLeSoir = estPlusDe18H;
        }

        /// <inheritdoc />
        public bool SommesNousLeSoir { get; }
    }
}
