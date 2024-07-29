Easily reference plain configuration files.

public Dictionary<string,string> GetConfig() {
    var utf8Parser = new UtfParser("..\\..\\config");
    var config = utf8Parser.GetKeyValuePair();

    return config;
}

public string GetKey() {
    var config = GetConfig();

    return config["key1"];
}

config:

key1="YHKS767SDSD65"
