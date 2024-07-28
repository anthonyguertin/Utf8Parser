using Utf8ConfigFileParser;
namespace Utf8ConfigFileParserUnitTests
{
    [TestClass]
    public class Utf8ConfigFileParserUnitTests
    {
        private static readonly string ConfigPath = @"..\..\..\config";
        [TestMethod]
        public void GetKeyValuePairTest()
        {
            var parser = new UtfParser(ConfigPath);
            var config = parser.GetKeyValuePair();

            const string expected_key1 = "this is a test key for unit testing which should have multiple lines wherever that utf8 file newline(s) are there should be a word wrap this may be the next line or it may not. This is a line break before the 3rd line would've automatically been created because of the length of the previous line.";
            const string expected_key2 = "1234567889";
            const string expected_key3 = "the previous key has a blank line between it and this key.";
            const string expected_key4 = "    this key has 4 white spaces before the beginning of entry of the key";
            const string expected_key5 = "thiskeyhasspecialcharacters*&^%$#@!*)";
            const string expected_key6 = "\"this key has quotations\"" + " and a 3 line gap between it and previous key.";

            var actual_key1 = config["key1"];
            var actual_key2 = config["key2"];
            var actual_key3 = config["key3"];
            var actual_key4 = config["key4"];
            var actual_key5 = config["key5"];
            var actual_key6 = config["key6"];


            Assert.AreEqual(expected_key1, actual_key1);
            Assert.AreEqual(expected_key2, actual_key2);
            Assert.AreEqual(expected_key3, actual_key3);
            Assert.AreEqual(expected_key4, actual_key4);
            Assert.AreEqual(expected_key5, actual_key5);
            Assert.AreEqual(expected_key6, actual_key6);

        }
    }
}