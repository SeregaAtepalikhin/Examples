int[] array = { 1, 12, 22, 23, 66, 33, 44, 55, 66, 88, 77 };

int n = array.Length;
int find = 66;

int index = 0;

while (index < n)
{

  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  //index = index +1;
  index++;
}