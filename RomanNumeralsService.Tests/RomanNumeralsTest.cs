using System;
using FluentAssertions;
namespace RomanNumeralsService.Tests
{
	public class RomanNumeralsTest
	{
        private RomanNumerals _RomanNumeralsConverter;
        [SetUp]
        public void Setup()
        {
            _RomanNumeralsConverter = new RomanNumerals();
        }

        [Test]
        public void Roman_Numerals_Returns_I()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(1).Should().Be("I");
        }
        [Test]
        public void Roman_Numerals_Returns_II()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(2).Should().Be("II");
        }
        [Test]
        public void Roman_Numerals_Returns_III()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(3).Should().Be("III");
        }
        [Test]
        public void Roman_Numerals_Returns_IV()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(4).Should().Be("IV");
        }
        [Test]
        public void Roman_Numerals_Returns_CDXLIV()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(444).Should().Be("CDXLIV");
        }
        [Test]
        public void Roman_Numerals_Returns_CMXCIX()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(999).Should().Be("CMXCIX");
        }
        [Test]
        public void Roman_Numerals_Returns_MMCMXCIX()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(2999).Should().Be("MMCMXCIX");
        }
        [Test]
        public void Roman_Numerals_Returns_MMMCMXCIX()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(3999).Should().Be("MMMCMXCIX");
        }
        [Test]
        public void Roman_Numerals_Returns_MMMMCMXCIX()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(4999).Should().Be("MMMMCMXCIX");
        }
        [Test]
        public void Roman_Numerals_Returns_Invalid_Input()
        {
            _RomanNumeralsConverter.RomanNumeralsConverter(0).Should().Be("Only values ranging from 1-4999 can be converted using this application");
        }
    }
}

