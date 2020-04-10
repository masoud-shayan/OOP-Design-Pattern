using System;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

public static class Dumper{
    public static void Dump(this object data)
    {
        string json = JsonConvert.SerializeObject(data , Formatting.Indented);
        Console.WriteLine(json);
    }
}