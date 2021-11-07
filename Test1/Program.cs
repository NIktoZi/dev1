// Задать массив 
int[] A = new int[10];

int index =0;
while (index<10)
{
A[index] = new Random().Next(10, 100); // [10,100)
    index++;
}
// Печатать массив 
index =0;
while (index<10)
{
Console.WriteLine(A[index]);
    index++;
}
// Исключение элементов возрастания 
Console.WriteLine();
Console.WriteLine("условие 1");
index =0;
int  firstE= A[0];
while (index<10)
{
     if (A[index]>firstE)
     {
         Console.WriteLine(A[index]);
         firstE = A[index];
     }
    index++;
}

// Больше средне арифмитического
Console.WriteLine();
int sum = 0;
int avr =0;
for(int i =0; i<A.Length; i++)
  sum+=A[i]; 
  avr= sum/A.Length;
  Console.WriteLine(avr +"  <Среднее");
    
    Console.WriteLine();
    index =0;
    while(index<A.Length)
    {
if(A[index]<avr)
Console.WriteLine(A[index]);
index++;
    }
    // нечетные числа
    Console.WriteLine();
    index =0;
    while(index<A.Length)
    {
        if(A[index]%2!=0)
        Console.WriteLine(A[index]);
        index++;
    }