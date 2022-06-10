using System;
using Grpc.Net.Client;
using GrpcService1;

using var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new Greeter.GreeterClient(channel);

Console.Write("Введите имя: ");
string name = Console.ReadLine();

var reply = await client.SayHelloAsync(new HelloRequest {Name = name});
Console.WriteLine("Ответ сервера: " + reply.Message);
Console.ReadKey();