Allows for developers to reference a UTF8 file(plain text) from source code in visual studio.

Sample usage would be:

public string GetKey() {
    var ConfigPath = @"..\..\..\config";

    var parser = new UtfParser(ConfigPath);
    var config = parser.GetKeyValuePair();

    var key1 = config["key1"];
    var apiKey = key1;

    return apiKey;
}