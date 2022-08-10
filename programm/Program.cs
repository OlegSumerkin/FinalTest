// See https://aka.ms/new-console-template for more information
int N;
int count=0;
int j=0;
Console.WriteLine("Please enter the number of elements, that you wants to enter: ");
N=Convert.ToInt32(Console.ReadLine());
string[] array=new string[N];
do{
for(int i=0;i<N;i++){
    Console.WriteLine($"Please enter element number {i+1}: ");
    array[i]=Console.ReadLine();
    if(array[i].Length<=3) count++;
}
if(count==0) Console.WriteLine("The amount of needed elements is 0. Please try again.");
}
while(count==0);

string[] array2= new string[count];

Console.WriteLine("Result array: ");
Console.Write("[");
for(int i=0;i<N;i++){
    if(array[i].Length<=3){ 
        array2[j]=array[i];
            if(j==count-1) Console.Write($"{array2[j]}");
            else Console.Write($"{array2[j]}, ");
        j++;}
}
Console.Write("]");