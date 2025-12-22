// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

Terrain terrain = new Terrain()
{
    id = 5,
    name = "example"
};

var options = new JsonSerializerOptions
{
    TypeInfoResolver = AppJsonSerializerContext.Default
};

string jsonString = JsonSerializer.Serialize(terrain, options);

Console.WriteLine(jsonString);


public class Terrain()
{
    public int id {get;set;}
    public string name {get;set;}
}

[JsonSerializable(typeof(Terrain))]
public partial class AppJsonSerializerContext : JsonSerializerContext
{
}

