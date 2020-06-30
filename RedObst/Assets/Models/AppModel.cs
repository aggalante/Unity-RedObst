public class AppModel
{
    public static int level = 1;

    public static float forwardForce = 4000f;

    public static float forceIncrement = 2000f;

    public static float sideForce = 100f;

    public static float restartDelay = 1f;

    public static bool levelCompleted;

    public static bool tryAgain;

    public static int maxLevel = 3;

    public static void Reset()
    {
        tryAgain = false;
        levelCompleted = false;
        //level = 1;
        //forwardForce = 4000f;
        //forceIncrement = 2000f;
        //sideForce = 100f;
    }
}
