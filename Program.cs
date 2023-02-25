string[] text={"Hey","rock","n","roll"};
int maxLength=3;

for (int i = 0; i < text.Length; i++)
{
        if(text[i].Length<=maxLength)
    {

Console.Write($"{text[i]} ");
    }

}

