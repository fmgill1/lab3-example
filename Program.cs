
const int CONVERSION_RATE = 7;
int dogsAge = GetDogsAge();
int humanAge = ConvertDogsAge(dogsAge);
DisplayMessage(humanAge);

static int GetDogsAge()
{
    System.Console.WriteLine("Please enter your dogs age in years:");
    int dogsAge = int.Parse(Console.ReadLine());
    return dogsAge;
}

static int ConvertDogsAge(int dogsAge)
{
    int humanAge = 0;
    humanAge = dogsAge * CONVERSION_RATE;
    return humanAge;
}

static void DisplayMessage(int humanAge)
{
    DisplayConvertedAge(humanAge);
    if(humanAge <= 35)
    {
        System.Console.WriteLine("Your dog is still pretty young!");
    }
    else if(humanAge > 35 && humanAge < 100)
    {
        System.Console.WriteLine("Your dog is middle-aged!");
    }
    else if(humanAge >= 100)
    {
        System.Console.WriteLine("You can call your dog a centenarian!");
    }

}

static void DisplayConvertedAge(int humanAge)
{
    System.Console.WriteLine("Your dog is " + humanAge + " human-years old.");
}

