List<int> maxSet1 = new List<int>() { 1,5,3 };
List<int> maxSet2 = new List<int>() { 9,7,3,-2};
List<int> maxSet3 = new List<int>() { 2,1,2};
List<List<int>> maxSetMain = new List<List<int>>() { maxSet1,maxSet2,maxSet3 };

List<int> highestGrade1 = new List<int>() { 85, 92, 67, 94, 94 };
List<int> highestGrade2 = new List<int>() { 50, 60, 57, 95 };
List<int> highestGrade3 = new List<int>() { 95 };
List<List<int>> highestGradeMain = new List<List<int>>() { highestGrade1, highestGrade2, highestGrade3 };

List<int> unordered = new List<int>() { 6, -2, 5, 3 };

int listNum = 1;

foreach (int element in MaxNumbersInLists(maxSetMain)){
    
    Console.WriteLine("Max numbers of List "+listNum+": " + element);
    listNum++;
}

Console.WriteLine(HighestGrade(highestGradeMain));

foreach (int element in OrderByLooping(unordered))
{
    Console.WriteLine(element);
}

    List<int> MaxNumbersInLists(List<List<int>> input)
{
    List<int> maxNums = new List<int>();

    int maxNum = 0;

    foreach (List<int> group in input)
    {
        maxNum = 0;//reset it after its done iterating through a list

        foreach (int number in group)
        {
            if(maxNum < number)
            {
                maxNum = number;
            }
        }

        maxNums.Add(maxNum);
    }

    return maxNums;
}

string HighestGrade(List<List<int>> input)
{
    int maxNum = 0;
    int classroom = 0;
    int highestClassroom = 0;

    foreach (List<int> group in input)
    {
        classroom++;
        foreach (int number in group)
        {
            if (maxNum < number)
            {
                highestClassroom = classroom;
                maxNum = number;
            }
        }
    }

    return "The highest grade in all of the classes is: " +maxNum+ " In class number: " + highestClassroom;
}

List<int> OrderByLooping(List<int> input)
{
    List<int> order = new List<int>();
    bool isOrdered = false;


    foreach(int element in input)
    {
        while (isOrdered = false)
        {

        }
        order.Add(element);
    }

    return order;
}
