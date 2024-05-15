using CatFactWritter;

//TODO implement DI

// testing
var a = new HttpClient();
HttpClientService test = new(a, "https://catfact.ninja/fact");

var sentence = await test.GetSentence();
Console.WriteLine(sentence);

var sentence2 = await test.GetSentence();
Console.WriteLine(sentence2);

