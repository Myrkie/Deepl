using System.Net;
using DeeplTranslator = Deepl.Deepl; 
using Language = Deepl.Deepl.Language;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine(TranslateText("【3Dモデル】Xena -ゼナ-"));


        Thread.Sleep(500000);
    }
    
    private static string TranslateText(string input)
    {
        var translate = new DeeplTranslator(selectedLanguage: Language.JP, targetLanguage: Language.EN, input,"1231232313", new NetworkCredential("nfbnwiiu", "oa2ev6ilh71n"));
        if (string.IsNullOrEmpty(translate.Resp)) return $"{input} \nThis Failed To translate";
        return translate.Resp;
    }
}