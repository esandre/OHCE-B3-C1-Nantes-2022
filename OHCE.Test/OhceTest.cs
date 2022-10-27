using FluentAssertions;
using NFluent;
using OHCE.Test.Utilities;

namespace OHCE.Test
{
    public class OhceTest
    {
        [Theory(DisplayName = "QUAND on saisit une chaîne <chaîne>" +
                            "ALORS celle-ci est renvoyée en miroir")]
        [InlineData("toto")]
        [InlineData("test")]
        public void TestRenvoiMiroir(string chaîne)
        {
            // QUAND on saisit une chaîne
            var resultat = Ohce.Palindrome(chaîne);

            // ALORS celle-ci est renvoyée en miroir
            var miroir = new string(chaîne.Reverse().ToArray());
            Assert.Contains(miroir, resultat);
            Check.That(resultat).Contains(miroir);
        }

        [Fact(DisplayName = "QUAND on saisit un palindrome " +
                            "ALORS celui-ci est renvoyé " +
                            "ET «Bien dit» est envoyé ensuite")]
        public void TestBienDit()
        {
            const string palindrome = "radar";

            // QUAND on saisit un palindrome
            var resultat = Ohce.Palindrome(palindrome);

            // ALORS celui-ci est renvoyé
            Assert.Contains(palindrome, resultat);
            Check.That(resultat).Contains(palindrome);
            
            // ET «Bien dit» est envoyé ensuite
            Assert.Contains("Bien dit", resultat.TruncateUntil(palindrome));
            Check.That(resultat.TruncateUntil(palindrome)).Contains("Bien dit");
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne autre qu'un palindrome " +
                            "ALORS «Bien dit» est absent")]
        public void TestBienDitAbsent()
        {
            // QUAND on saisit une chaîne autre qu'un palindrome
            var resultat = Ohce.Palindrome("test");

            // ALORS «Bien dit» est absent
            Assert.DoesNotContain("Bien dit", resultat);
            Check.That(resultat).DoesNotContain("Bien dit");
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne " +
                            "ALORS «Bonjour» est envoyé avant toute réponse")]
        public void TestBonjour()
        {
            // QUAND on saisit une chaîne
            var resultat = Ohce.Palindrome(string.Empty);

            // ALORS «Bonjour» est envoyé avant toute réponse
            Check.That(resultat).StartsWith("Bonjour");
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne " +
                            "ALORS «Au revoir» est envoyé en dernier")]
        public void TestAuRevoir()
        {
            // QUAND on saisit une chaîne
            var resultat = Ohce.Palindrome(string.Empty);

            // ALORS «Au revoir» est envoyé en dernier
            Assert.EndsWith("Au revoir", resultat);
            Check.That(resultat).EndsWith("Au revoir");
        }
    }
}
