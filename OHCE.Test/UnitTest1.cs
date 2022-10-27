using OHCE.Test.Utilities;

namespace OHCE.Test
{
    public class UnitTest1
    {
        [Fact(DisplayName = "QUAND on envoie un mot 'toto' ALORS on obtient son miroir")]
        public void TestMiroirToto()
        {
            //QUAND on envoie un mot
            var resultat = new Ohce(new HorlogeStub()).Traiter("toto");

            //ALORS on obtient son miroir
            Assert.Contains("otot", resultat);
        }

        [Fact(DisplayName = "QUAND on envoie un mot 'bouif' ALORS on obtient son miroir")]
        public void TestMiroirBouif()
        {
            //QUAND on envoie un mot
            var resultat = new Ohce(new HorlogeStub()).Traiter("bouif");

            //ALORS on obtient son miroir
            Assert.Contains("fiuob", resultat);
        }

        [Fact(DisplayName = "QUAND on envoie un palindrome " +
                            "ALORS on obtient celui-ci " +
                            "ET 'Bien dit !' est ajouté")]
        public void TestPalindrome()
        {
            const string palindrome = "radar";

            //QUAND on envoie un mot
            var resultat = new Ohce(new HorlogeStub()).Traiter(palindrome);

            //ALORS on obtient celui-ci
            Assert.Contains(palindrome, resultat);

            var indexOfPalindrome = resultat.IndexOf(palindrome, StringComparison.Ordinal);
            var endOfPalindrome = indexOfPalindrome + palindrome.Length;
            resultat = resultat[endOfPalindrome..];

            //ET 'Bien dit !' est ajouté
            Assert.Contains("Bien dit !", resultat);
        }

        [Fact(DisplayName = "ETANT DONNE que nous sommes avant 18h" +
                            "QUAND on demande à être salué " +
                            "ALORS on obtient 'Bonjour'")]
        public void TestBonjour()
        {
            //ETANT DONNE que nous sommes avant 18h
            var horloge = new HorlogeRéglable(false);
            var ohce = new Ohce(horloge);

            //QUAND on envoie un mot
            var resultat = ohce.DemanderSalutations();

            //ALORS on obtient en premier 'Bonjour'
            Assert.Equal("Bonjour", resultat);
        }

        [Fact(DisplayName = "ETANT DONNE que nous sommes après 18h" +
                            "QUAND on demande à être salué " +
                            "ALORS on obtient 'Bonsoir'")]
        public void TestBonsoir()
        {
            //ETANT DONNE que nous sommes après 18h
            var horloge = new HorlogeRéglable(true);
            var ohce = new Ohce(horloge);

            //QUAND on envoie un mot
            var resultat = ohce.DemanderSalutations();

            //ALORS on obtient 'Bonsoir'
            Assert.Equal("Bonsoir", resultat);
        }

        [Fact(DisplayName = "QUAND on envoie un mot " +
                            "ALORS on obtient en dernier 'Au revoir'")]
        public void TestAuRevoir()
        {
            //QUAND on envoie un mot
            var resultat = new Ohce(new HorlogeStub()).Traiter(string.Empty);

            //ALORS on obtient en premier 'Bonjour'
            Assert.EndsWith("Au revoir", resultat);
        }

        [Fact(DisplayName = "QUAND on envoie un mot sans demander à être salué" +
                            "ALORS on obtient aucune formule de salutation")]
        public void TestNonSalué()
        {
            //QUAND on envoie un mot sans demander à être salué
            var resultat = new Ohce(new HorlogeStub()).Traiter(string.Empty);

            //ALORS on obtient aucune formule de salutation
            Assert.DoesNotContain("Bonjour", resultat);
            Assert.DoesNotContain("Bonsoir", resultat);
        }
    }
}