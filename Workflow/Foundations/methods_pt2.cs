// If return type is void, it means the method returns no data
void SayHello()
{
  Console.WriteLine("Hello World!");
}

SayHello();

int[] a = { 1, 2, 3, 4, 5 };

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
  foreach (int x in a)
  {
    Console.Write($"{x} ");
  }
  Console.WriteLine();
}

// Naming Convention Examples
void ShowData(string a, int b, int c);
void DisplayDate(string month, int day, int year);

// Method: Display Random Numbers
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
  Random random = new();

  for (int i = 0; i < 5; i++)
  {
    Console.Write($"{random.Next(1, 100)} ");
  }

  Console.WriteLine();
}

// Using Methods through if statements
int[] times = [800, 1200, 1600, 2000];
int diff;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
  Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
  diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
  AdjustTimes();
}
else
{
  diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
  AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

void DisplayTimes()
{
  /* Format and display medicine times */
  foreach (int val in times)
  {
    string time = val.ToString();
    int len = time.Length;

    if (len >= 3)
    {
      time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
      time = time.Insert(0, "0:");
    }
    else
    {
      time = time.Insert(0, "0:0");
    }

    Console.Write($"{time} ");
  }
  Console.WriteLine();
}

void AdjustTimes()
{
  /* Adjust the times by adding the difference, keeping the value within 24 hours */
  for (int i = 0; i < times.Length; i++)
  {
    times[i] = (times[i] + diff) % 2400;
  }
}