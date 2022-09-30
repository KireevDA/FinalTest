
string? yesNo = "";
while (yesNo.ToLower() != "1" && yesNo.ToLower() != "2")
{
  Console.Write("Если хотите ввести данные массива самостоятельно,\nнажмите - 1,\nесли нет,\nнажмите - 2: "); //(yes/no):
  yesNo = Console.ReadLine();
}

string[] arrayOfStrings = new string[]  {};

if (yesNo.ToLower() == "1") {
  int n = InputNumbers("Введите количество элементов массива: ");
  arrayOfStrings = new string[n];
  for (int i = 0; i < arrayOfStrings.Length; i++)
  {
    Console.Write($"Введите {i+1} элемент: ");
    arrayOfStrings[i] = Console.ReadLine();
  }
}
else 
{
  arrayOfStrings = new string[]  {"1234", "1567", "-2", "computer science"};
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int lengthLimit = 3;

int numbersItems = CheckArray(arrayOfStrings, lengthLimit);

string[] newArrayOfStrings = new string[numbersItems];

FillNewArray(arrayOfStrings, newArrayOfStrings, lengthLimit);


void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
  int j = 0;
  for (int i = 0; i < oldArray.Length; i++)
  {
    if (oldArray[i].Length <= lengthLimit)
    {
      newArray[j] = oldArray[i];
      j++;
    }
  }
}

int CheckArray(string[] array, int lengthLimit)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthLimit) result++;
  }
  return result;
}

string ShowArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}

Console.WriteLine($"{ShowArray(arrayOfStrings)} -> {ShowArray(newArrayOfStrings)}");

