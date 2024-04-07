using Garnet;
using Garnet.client;



var garnet = new GarnetClient( address:"127.0.0.1", port:3278);

await garnet.ConnectAsync();

var pong = await garnet.PingAsync();

Console.WriteLine(pong);


string origValue = "abcdefg";
await garnet.StringSetAsync("test", origValue);

string retValue = await garnet.StringGetAsync("test");

Console.WriteLine(retValue);




//var redis = ConnectionMultiplexer.Connect("127.0.0.1");

//var db = redis.GetDatabase();


//db.StringSet("mykey", "myvalue");


//string value = db.StringGet("mykey");

//Console.WriteLine(value); 

//var x = 5;



//Console.WriteLine("Hello, World!");
