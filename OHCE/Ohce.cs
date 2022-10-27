using System.Text;

namespace OHCE
{
    public class Ohce
    {
        private readonly IHorloge _horloge;

        public Ohce(IHorloge horloge)
        {
            _horloge = horloge;
        }

        public string Traiter(string mot)
        {
            var stringBuilder = new StringBuilder();

            var miroir = new string(mot.Reverse().ToArray());
            stringBuilder.Append(miroir);

            if (miroir.Equals(mot))
                stringBuilder.Append("Bien dit !");

            stringBuilder.Append("Au revoir");
            return stringBuilder.ToString();
        }

        public string DemanderSalutations()
        {
            return _horloge.SommesNousLeSoir ? "Bonsoir" : "Bonjour";
        }
    }
}
