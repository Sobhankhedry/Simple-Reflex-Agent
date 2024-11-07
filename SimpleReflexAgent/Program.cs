public class Agent
{
    public static bool LeftRoom = false;
    public static bool RightRoom = false;
    public static string[] Rooms = { "Dirty", "Dirty" };
    public static int number = 1;
    public static int MAX_SCORE = 0;
    public static void Main(String[] args)
    {
        CleanRoom("Left", "Suck", LeftRoom, RightRoom);
    }

    public static string CleanRoom(string currentLocation, string action, bool leftRoom, bool rightRoom)
    {
        if (leftRoom == true && rightRoom == true)
        {
            int score = MAX_SCORE * 100 / 2;

            Console.WriteLine($"({number}) all rooms are clean with the {score} score!!");
            return "nothing";
        }
        if (action == "Suck")
        {
            if (currentLocation == "Left" && leftRoom == false)
            {
                LeftRoom = true;
                Console.WriteLine($"({number}) Sucked the dirt in the Left room and we will go to right room");
                number++;
                MAX_SCORE++;
                CleanRoom("Right", "Go Right", LeftRoom, RightRoom);
            }
            else if (currentLocation == "Left" && leftRoom == true)
            {
                Console.WriteLine($"({number}) Left Room is already clean and going to Right");
                number++;
                CleanRoom("Right", "Go Right", LeftRoom, RightRoom);
            }
            else if (currentLocation == "Right" && rightRoom == false)
            {
                RightRoom = true;
                Console.WriteLine($"({number}) Sucked the dirt in the Right room and we will go to Left room");
                number++;
                MAX_SCORE++;
                CleanRoom("Left", "Go Left", LeftRoom, RightRoom);
            }
            else if (currentLocation == "Right" && rightRoom == true)
            {
                Console.WriteLine($"({number}) Right Room is already clean and going to Right");
                number++;
                CleanRoom("Left", "Go Left", LeftRoom, RightRoom);
            }

        }
        if (action == "Go Left")
        {
            if (LeftRoom)
            {
                Console.WriteLine($"({number}) Left Room is already clean and going to Right");
                number++;
                CleanRoom("Right", "Go Right", LeftRoom, RightRoom);
            }
            else
            {
                Console.WriteLine($"({number}) The Left Room has to be cleaned");
                number++;
                CleanRoom("Left", "Suck", LeftRoom, RightRoom);
            }
        }
        if (action == "Go Right")
        {

            if (RightRoom)
            {
                Console.WriteLine($"({number}) Right Room is already clean and going to Right");
                number++;
                CleanRoom("Left", "Go Left", LeftRoom, LeftRoom);
            }
            else
            {
                Console.WriteLine($"({number}) The Right Room has to be cleaned");
                number++;
                CleanRoom("Right", "Suck", LeftRoom, RightRoom);
            }
        }
        return "nothing";
    }
}