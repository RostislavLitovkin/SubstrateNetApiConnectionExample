// See https://aka.ms/new-console-template for more information

using Substrate.NetApi;

// Change to wss://127.0.0.1:8000
var wss = "wss://rpc.helikon.io/hydradx";

Console.WriteLine("Connecting to: " + wss);

var client = new SubstrateClient(new Uri(wss), default);

await client.ConnectAsync();

Console.WriteLine("Successfully connected to: " + await client.System.ChainAsync());

Console.ReadKey();
