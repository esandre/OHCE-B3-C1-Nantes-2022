namespace OHCE.Test
{
    public class OhceTest
    {
        [Fact(DisplayName = "QUAND on saisit une chaîne 'toto'" +
                            "ALORS celle-ci est renvoyée en miroir")]
        public void TestRenvoiMiroirToto()
        {
            // QUAND on saisit une chaîne
            var resultat = Ohce.Palindrome("toto");

            // ALORS celle-ci est renvoyée en miroir
            Assert.Equal("otot", resultat);
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne 'test'" +
                            "ALORS celle-ci est renvoyée en miroir")]
        public void TestRenvoiMiroirTest()
        {
            // QUAND on saisit une chaîne
            var resultat = Ohce.Palindrome("test");

            // ALORS celle-ci est renvoyée en miroir
            Assert.Equal("tset", resultat);
        }
    }
}
