using System;
using System.Net;
using System.Threading;
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
        var translate = new DeeplTranslator(selectedLanguage: Language.JP, targetLanguage: Language.EN, input,"1111", new NetworkCredential("1111", "1111"));
        if (string.IsNullOrEmpty(translate.Resp)) return $"{input} \nThis Failed To translate";
        return translate.Resp;
    }
}