
string[] array={"Hey","rock","n","roll"};
int maxLength=3;
string[] array2=new string[array.Length];
int count=0;
for (int i = 0; i < array.Length; i++)

{
  
        if(array[i].Length<=maxLength)
    {
        array2[count] =array[i];
        count++;
    }

}
foreach (var item in array2)
{
    Console.Write(item);
}