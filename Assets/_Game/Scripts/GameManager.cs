public class GameManager : FastSingleton<GameManager>
{
    public bool selected;
    public bool gameover;
    public bool turnRed;

    private void Start()
    {
        selected = false;
        turnRed = true;
        gameover = false;
    }

    private void Update()
    {
        if (gameover)
        {

        }
    }
}
