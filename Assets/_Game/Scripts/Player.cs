using UnityEngine;

public class Player : MonoBehaviour
{
    GameManager gameManager;
    Chess chess;
    [SerializeField] ColorChess color;
    private void Start()
    {
        gameManager = GameManager.instance;
        chess = null;
    }
    private void Update()
    {
        if (gameManager.turnRed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (!gameManager.selected)
                {
                    if (hit.collider != null && hit.collider.CompareTag(Constant.TAG_CHESS))
                    {
                        chess = hit.collider.gameObject.GetComponent<Chess>();
                        if (chess.GetColor() == (int)color)
                        {
                            gameManager.selected = true;
                            ChessSpawner.instance.CheckCanMove(chess);
                        }

                        //chess.Move();
                    }
                    else
                    {
                        ChessSpawner.instance.ResetCanMove();
                        ChessSpawner.instance.DisplayPoint();
                        gameManager.selected = false;
                    }
                }
                else
                {
                    if (hit.collider != null && hit.collider.CompareTag(Constant.TAG_POINT))
                    {
                        Point point = hit.collider.gameObject.GetComponent<Point>();
                        if (point.canMove && chess != null)
                        {
                            ChessSpawner.instance.MoveToPoint(chess, point);
                            gameManager.selected = false;
                            gameManager.turnRed = false;
                        }
                        else
                        {
                            ChessSpawner.instance.ResetCanMove();
                            ChessSpawner.instance.DisplayPoint();
                            gameManager.selected = false;

                        }
                    }
                    else
                    {
                        ChessSpawner.instance.ResetCanMove();
                        ChessSpawner.instance.DisplayPoint();
                        gameManager.selected = false;
                    }

                }

            }
        }
    }
}
