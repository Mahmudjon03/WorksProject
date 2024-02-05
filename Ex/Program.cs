//int key;

//System.Console.Write("Key: ");

//key = Convert.ToInt16(Console.ReadLine());

//string text, text2 = "";

//System.Console.Write("Text: ");

//text = Console.ReadLine();

//for (int i = 0; i < text.Length; i++)
//{
//    text2 += (char)((text[i] + key) % 'z');
//}
//Console.WriteLine(text2);


//     int key2;

//    System.Console.Write("Key2: ");
//    key2 = Convert.ToInt16(Console.ReadLine());
//    Console.Write("Text: ");
//    string text3 = "", test = Console.ReadLine();

//    for (int i = 0; i < test.Length; i++)
//    {
//        text3 += (char)((test[i] - key2) % 'z');
//    }
//    System.Console.WriteLine(text3);


using System.Xml;

UriBuilder uriBuilder1 = new UriBuilder("https", "metanit.com", 443, "php/index");
Uri url1 = uriBuilder1.Uri;
Console.WriteLine(url1);    // https://metanit.com/sharp/net

UriBuilder uriBuilder2 = new UriBuilder();
uriBuilder2.Scheme = "https";
uriBuilder2.Host = "somesite.com";
uriBuilder2.Port = 80;
uriBuilder2.Path = "home";
uriBuilder2.Query = "name=Tom&age=38";
uriBuilder2.Fragment = "account-info";
Uri url2 = uriBuilder2.Uri;
Console.WriteLine(url2);