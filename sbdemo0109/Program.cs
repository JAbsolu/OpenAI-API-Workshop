using System;
using System.Threading.Tasks;
using OpenAI_API;
using dotenv.net;

DotEnv.Load();

string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var api = new OpenAIAPI(apiKey);

var request = new OpenAI_API.Images.ImageGenerationRequest
{
  Prompt = "A cute kitten in a basket"
};

// creata images
var response = await api.ImageGenerations.CreateImageAsync(request);
Console.WriteLine("Image URL: {0}", response.Data[0].Url);