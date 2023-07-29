//Есть текст.
//В тексте необходимо заменить все пробелы _,
//буквы "к" заменить на "К",
// буквы "с" замень на "С". 

string textUser = "Мы вынуждены отталкиваться от того, что существующая"
                + "теория однозначно фиксирует необходимость"
                + "системы массового участия.";
Console.WriteLine(textUser);

string newText = ReplaceText(ReplaceText(ReplaceText(textUser, ' ', '_'), 'к', 'К'), 'с', 'С');
Console.WriteLine(newText);

string ReplaceText(string text, char symbol, char newSymbol)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == symbol) result = result + newSymbol;
        else result = result + text[i];
    }
    return result;
}

