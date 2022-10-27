namespace OHCE
{
    internal class HorlogeSystème : IHorloge
    {
        /// <inheritdoc />
        public bool SommesNousLeSoir => DateTime.Now.Hour >= 18;
    }
}
