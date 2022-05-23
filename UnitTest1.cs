using NUnit.Framework;
using FluentAssertions;

namespace RomanKataProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            /*
            // Try some simpler to compute 'additive' Roman numerals ...

            RomanNumeralConverter romannumeralconverter = new();

            romannumeralconverter.ConvertAnAdditiveRomanNumeral("MMDCLXVI").Should().Be(2666);
            romannumeralconverter.ConvertAnAdditiveRomanNumeral("MMMM").Should().Be(4000);
            romannumeralconverter.ConvertAnAdditiveRomanNumeral("I").Should().Be(1);
            */
        }

        [Test]
        public void Test2()
        {
            /*
            // Next, use the previous 'additive' test cases with with the 'subtractive' method ...

            RomanNumeralConverter romannumeralconverter = new();

            romannumeralconverter.ConvertARomanNumeral("MMDCLXVI").Should().Be(2666);
            romannumeralconverter.ConvertARomanNumeral("MMMM").Should().Be(4000);
            romannumeralconverter.ConvertARomanNumeral("I").Should().Be(1);
            */
        }

        [Test]
        public void Test3()
        {
             // Try the simpler 'additive' Roman numerals to make sure the method falls through to handle these ...

             RomanNumeralConverter romannumeralconverter = new();

             romannumeralconverter.ConvertAnAdditiveRomanNumeral("MMMM").Should().Be(4000);
             romannumeralconverter.ConvertAnAdditiveRomanNumeral("I").Should().Be(1);
             romannumeralconverter.ConvertAnAdditiveRomanNumeral("MMDCLXVI").Should().Be(2666);
            
            // Now try some more complex 'subtractive' test cases with the 'subtractive' method ...

             romannumeralconverter.ConvertARomanNumeral("IV").Should().Be(4);
             romannumeralconverter.ConvertARomanNumeral("IX").Should().Be(9);
             romannumeralconverter.ConvertARomanNumeral("XIV").Should().Be(14);
             romannumeralconverter.ConvertARomanNumeral("XIX").Should().Be(19);
             romannumeralconverter.ConvertARomanNumeral("XLIX").Should().Be(49);
             romannumeralconverter.ConvertARomanNumeral("XC").Should().Be(90);
             romannumeralconverter.ConvertARomanNumeral("XCIX").Should().Be(99);
             romannumeralconverter.ConvertARomanNumeral("CD").Should().Be(400);
             romannumeralconverter.ConvertARomanNumeral("CDXC").Should().Be(490);
             romannumeralconverter.ConvertARomanNumeral("CM").Should().Be(900);
             romannumeralconverter.ConvertARomanNumeral("CMXCIX").Should().Be(999);
             romannumeralconverter.ConvertARomanNumeral("MMMCMXCIX").Should().Be(3999);
        }

        [Test]
        public void Test4()
        {
            // Now convert an Arabic integer to a Roman Numeral ...

            RomanNumeralConverter romannumeralconverter = new();
            
            romannumeralconverter.ConvertAnArabicInteger(1).Should().Be("I");
            romannumeralconverter.ConvertAnArabicInteger(4).Should().Be("IV");
            romannumeralconverter.ConvertAnArabicInteger(6).Should().Be("VI");
            romannumeralconverter.ConvertAnArabicInteger(7).Should().Be("VII");
            romannumeralconverter.ConvertAnArabicInteger(9).Should().Be("IX");
            romannumeralconverter.ConvertAnArabicInteger(10).Should().Be("X");
            romannumeralconverter.ConvertAnArabicInteger(19).Should().Be("XIX");
            romannumeralconverter.ConvertAnArabicInteger(44).Should().Be("XLIV");
            romannumeralconverter.ConvertAnArabicInteger(90).Should().Be("XC");
            romannumeralconverter.ConvertAnArabicInteger(110).Should().Be("CX");
            romannumeralconverter.ConvertAnArabicInteger(400).Should().Be("CD");
            romannumeralconverter.ConvertAnArabicInteger(500).Should().Be("D");
            romannumeralconverter.ConvertAnArabicInteger(490).Should().Be("CDXC");
            romannumeralconverter.ConvertAnArabicInteger(510).Should().Be("DX");
            romannumeralconverter.ConvertAnArabicInteger(900).Should().Be("CM");
            romannumeralconverter.ConvertAnArabicInteger(1000).Should().Be("M");
            romannumeralconverter.ConvertAnArabicInteger(1100).Should().Be("MC");
            romannumeralconverter.ConvertAnArabicInteger(1400).Should().Be("MCD");
            romannumeralconverter.ConvertAnArabicInteger(1994).Should().Be("MCMXCIV");
            romannumeralconverter.ConvertAnArabicInteger(3000).Should().Be("MMM");
            romannumeralconverter.ConvertAnArabicInteger(2900).Should().Be("MMCM");
        }
    }
}