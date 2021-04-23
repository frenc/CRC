using NUnit.Framework;

namespace Exercises.Exercise5
{
    [TestFixture]
    public sealed class TextConverterTest
    {
        private TextConverter _textConverter;

        [SetUp]
        public void Setup()
        {
            _textConverter = new TextConverter();
        }

        [TestCase("String", "gnirtS")]
        [TestCase("OpsSissA", "AssiSspO")]
        public void ShouldReversText(string text, string expectedResult)
        {
            var result = _textConverter.ReversText(text);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase("String", "GNIRTs")]
        [TestCase("OpsSissA", "aSSIsSPo")]
        public void ShouldReversTextAndChangeLetterSize(string text, string expectedResult)
        {
            var result = _textConverter.ReversTextAndChangeLetterSize(text);
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [TestCase("Stri|ng", "IRTs|ng")]
        [TestCase("Op|sSissA", "Po|sSissA")]
        public void ShouldReversTextAndChangeLetterSizeBeforeSpecialCharacter(string text, string expectedResult)
        {
            var result = _textConverter.ReversTextAndChangeLetterSizeBeforeSpecialCharacter(text);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
