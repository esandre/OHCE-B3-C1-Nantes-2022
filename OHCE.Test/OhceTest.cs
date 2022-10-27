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
            Assert.Equal(miroir, resultat);
        }
    }
}
