using OpenAI_API;
using dotenv.net;

DotEnv.Load();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");


var key = new APIAuthentication(apiKey);

var api = new OpenAIAPI(key);
var prompt = "A long time ago, in a galazy far, far away...";
var request = new OpenAI_API.Completions.CompletionRequest(prompt, mode: OpenAI_API.Model.DavinciText, max_tokens: 100), temperature: 0.7; 
var response = await api.Completions.CreateCompletionAsync(request);
var completion = response.Choices[0].Text;
Console.WriteLine("Generated Text: {0}", completion);