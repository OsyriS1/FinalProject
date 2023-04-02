System.Console.WriteLine("Введите количество строк: " ) ;
int n = Convert.ToInt32(Console.ReadLine()) ;
string[] stringArray = new string [n] ; 
void array (string[] stringArray) 
{
for (int i = 0; i < stringArray.Length; i++)
{
    System.Console.WriteLine($"Введите {i+1} элемент массива" );
    stringArray[i] = Console.ReadLine() ; 
}
}
string[] finalProject (string[] StringArray)
{
    int j = 0 ;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <=3)
            j++ ;
    }
        string[] result = new string [j] ; 
        int k = 0 ;
        for (int i = 0; i < stringArray.Length; i++)
        {
            if (StringArray[i].Length <=3)
            {
                result[k] = stringArray[i];
                k++ ; 
            }
        }
        return result ; 
    }
void print(string [] stringArray)
{
    Console.Write("[");
    for (int i = 0;i<stringArray.Length;i++)
    {
    Console.Write($"{stringArray[i]}");
    }
    Console.Write("]");
}
array(stringArray);
print(finalProject(stringArray));
