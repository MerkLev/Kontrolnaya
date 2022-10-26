Console.Write("Введите размер массива:  ");
int Size = Convert.ToInt32(Console.ReadLine());
string [] Array = new string [Size];
Console.WriteLine("Вводите значения элементов:   ");
for(int i = 0; i < Size; i++)
{
   Array[i] = Console.ReadLine();
}
Console.Write("Полученный массив:   ");
Console.WriteLine(string.Join(", ", Array));

string word=Array[0];
int Count=0;

for (int i = 0; i < Size; i++)
{
   word=Array[i];
   if(word.Length<=3)
   {
      Count++;
   }
}
int j=0;
string [] Less3Array = new string [Count];


for (int i = 0; i < Size; i++)
{
   word=Array[i];
   if( word.Length <=3)
   {
      Less3Array[j]=Array[i];
      j++;
   }
}

Console.Write("Отсортированный массив элементов:   ");
Console.WriteLine(string.Join(", ", Less3Array));