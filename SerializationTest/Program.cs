// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");
Terrain terrain = new Terrain()
{
    id = 5,
    name = "blorbus"
};

var options = new JsonSerializerOptions
{
    TypeInfoResolver = AppJsonSerializerContext.Default
};

string jsonString = JsonSerializer.Serialize(terrain, options);

Console.WriteLine(jsonString);


public class Terrain()
{
    public int id;
    public string name;
}

[JsonSerializable(typeof(Terrain))]
[JsonSerializable(typeof(List<Terrain>))]
public partial class AppJsonSerializerContext : JsonSerializerContext
{
}

