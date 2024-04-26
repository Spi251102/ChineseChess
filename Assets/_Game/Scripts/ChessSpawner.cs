using System.Collections.Generic;
using UnityEngine;

public class ChessSpawner : FastSingleton<ChessSpawner>
{
    readonly float startx = -2.285f;
    readonly float endx = 2.297f;
    readonly float starty = -3.209f;
    readonly float endy = 3.242f;
    float stepx;
    float stepy;
    [SerializeField] private Transform pointTf;
    [SerializeField] Point pointPref;
    public List<Point> points = new();
    public List<Chess> listChess = new();
    //[SerializeField] private List<Chess> listChess = new();
    [SerializeField] private List<Chess> chessPref = new();
    [SerializeField] private Transform chessTf;

    private void Start()
    {
        stepx = (float)(endx - startx) / 8f;
        stepy = (float)(endy - starty) / 9f;
        OnInit();
    }

    public void OnInit()
    {
        StartGame();
        CreateChess();
    }

    private void StartGame()
    {
        for (float x = startx; x <= endx + .5f; x += stepx)
        {
            for (float y = starty; y <= endy + .5f; y += stepy)
            {
                Point point = Instantiate(pointPref, pointTf);
                point.value = 0;
                point.transform.position = new Vector3(x, y, -1);

                // Tính toán vị trí của điểm trên bàn cờ
                point.col = 1 + Mathf.RoundToInt((x - startx) / stepx);
                point.row = 1 + Mathf.RoundToInt((y - starty) / stepy);
                points.Add(point);

            }
        }


    }

    private void CreateChess()
    {
        for (int x = 1; x <= 9; x++)
        {
            for (int y = 1; y <= 10; y++)
            {
                if ((x == 1 && y == 1) || (x == 9 && y == 1) || (x == 1 && y == 10) || (x == 9 && y == 10))
                {
                    if (y < 6)
                    {
                        Chess chess = InstantiateChess(3, 1);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                    else
                    {
                        Chess chess = InstantiateChess(3, 0);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                }
                else if ((x == 2 && y == 1) || (x == 8 && y == 1) || (x == 2 && y == 10) || (x == 8 && y == 10))
                {
                    if (y < 6)
                    {
                        Chess chess = InstantiateChess(4, 1);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);

                    }
                    else
                    {
                        Chess chess = InstantiateChess(4, 0);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                }
                else if ((x == 3 && y == 1) || (x == 7 && y == 1) || (x == 3 && y == 10) || (x == 7 && y == 10))
                {
                    if (y < 6)
                    {
                        Chess chess = InstantiateChess(2, 1);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);

                    }
                    else
                    {
                        Chess chess = InstantiateChess(2, 0);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                }
                else if ((x == 4 && y == 1) || (x == 6 && y == 1) || (x == 4 && y == 10) || (x == 6 && y == 10))
                {
                    if (y < 6)
                    {
                        Chess chess = InstantiateChess(1, 1);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);

                    }
                    else
                    {
                        Chess chess = InstantiateChess(1, 0);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                }
                else if ((x == 2 && y == 3) || (x == 8 && y == 3) || (x == 2 && y == 8) || (x == 8 && y == 8))
                {
                    if (y < 6)
                    {
                        Chess chess = InstantiateChess(5, 1);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);

                    }
                    else
                    {
                        Chess chess = InstantiateChess(5, 0);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                }
                else if ((x == 5 && y == 1) || (x == 5 && y == 10))
                {
                    if (y < 6)
                    {
                        Chess chess = InstantiateChess(0, 1);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                    else
                    {
                        Chess chess = InstantiateChess(0, 0);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                }
                else if ((y == 4 || y == 7) && (x == 1 || x == 3 || x == 5 || x == 7 || x == 9))
                {
                    if (y < 6)
                    {
                        Chess chess = InstantiateChess(6, 1);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);

                    }
                    else
                    {
                        Chess chess = InstantiateChess(6, 0);
                        chess.transform.position = GetPositionPoint(x, y);
                        chess.currentCol = x;
                        chess.currentRow = y;
                        //chess.tf.position = new Vector3(chess.tf.position.x, chess.tf.position.y, -2);
                        listChess.Add(chess);
                    }
                }

            }
        }
    }

    private Chess InstantiateChess(int type, int color)
    {
        Chess chess = null;
        foreach (var c in chessPref)
        {
            if (c.GetTypeChess() == type && c.GetColor() == color)
            {
                chess = Instantiate(c, chessTf);
                break;
            }
        }

        if (chess == null)
        {
            chess = Instantiate(chessPref[0], chessTf);
        }

        return chess;
    }

    private Vector3 GetPositionPoint(int col, int row)
    {
        Point point = null;
        foreach (var p in points)
        {
            if (p.col == col && p.row == row)
            {
                point = p;
                break;
            }
        }

        if (point == null)
        {
            return new Vector3(0, 0, 0);
        }

        return new Vector3(point.tf.position.x, point.tf.position.y, -2);
    }

    public void DeActiveChess(Chess chess)
    {
        chess.gameObject.SetActive(false);

    }

    public void ActiveChess()
    {

    }

    public void MoveToPoint(Chess chess, Point point)
    {
        if (chess != null && point != null)
        {
            chess.currentCol = point.col;
            chess.currentRow = point.row;
            ResetCanMove();
            DisplayPoint();
            foreach (var c in listChess)
            {
                if (c.currentCol == point.col && c.currentRow == point.row && c.GetColor() != chess.GetColor())
                {
                    DeActiveChess(c);
                }
            }
            //chess.tf.position = point.tf.position;
            chess.tf.position = new Vector3(point.tf.position.x, point.tf.position.y, -2);
        }
    }

    public void CheckCanMove(Chess chess)
    {
        ResetCanMove();
        switch (chess.GetTypeChess())
        {
            case (int)TypeChess.Chancellor:
                foreach (var p in points)
                {
                    bool canMove = false;
                    if ((p.col == chess.currentCol && p.row == chess.currentRow + 1) ||
                        (p.col == chess.currentCol && p.row == chess.currentRow - 1) ||
                        (p.col == chess.currentCol + 1 && p.row == chess.currentRow) ||
                        (p.col == chess.currentCol - 1 && p.row == chess.currentRow))
                    {
                        if ((p.row <= 3 && chess.GetColor() == (int)ColorChess.Red) || (p.row >= 8 && chess.GetColor() == (int)ColorChess.Black))
                        {
                            if (p.col >= 4 && p.col <= 6)
                            {
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf && chess.GetColor() == c.GetColor())
                                    {
                                        canMove = false;
                                        break;
                                    }
                                    else
                                    {
                                        canMove = true;
                                    }
                                }
                            }
                        }
                    }
                    p.canMove = canMove;
                    DisplayPoint();
                }
                break;

            case (int)TypeChess.Guard:
                foreach (var p in points)
                {
                    bool canMove = false;
                    if ((p.col == chess.currentCol + 1 || p.col == chess.currentCol - 1) &&
                        (p.row == chess.currentRow + 1 || p.row == chess.currentRow - 1))
                    {
                        if ((p.row <= 3 && chess.GetColor() == (int)ColorChess.Red) ||
                            (p.row >= 8 && chess.GetColor() == (int)ColorChess.Black))
                        {
                            if (p.col >= 4 && p.col <= 6)
                            {
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf && chess.GetColor() == c.GetColor())
                                    {
                                        canMove = false;
                                        break;
                                    }
                                    else
                                    {
                                        canMove = true;
                                    }
                                }
                            }
                        }
                    }
                    p.canMove = canMove;
                    DisplayPoint();
                }
                break;

            case (int)TypeChess.Elephant:
                foreach (var p in points)
                {
                    bool canMove = false;
                    if ((p.col == chess.currentCol + 2 && p.row == chess.currentRow + 2) ||
                        (p.col == chess.currentCol + 2 && p.row == chess.currentRow - 2) ||
                        (p.col == chess.currentCol - 2 && p.row == chess.currentRow + 2) ||
                        (p.col == chess.currentCol - 2 && p.row == chess.currentRow - 2))
                    {
                        if ((p.row <= 5 && chess.GetColor() == (int)ColorChess.Red) || (p.row >= 6 && chess.GetColor() == (int)ColorChess.Black))
                        {
                            foreach (var c in listChess)
                            {
                                if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf && chess.GetColor() == c.GetColor())
                                {
                                    canMove = false;
                                    break;
                                }
                                else
                                {
                                    canMove = true;
                                }

                            }
                            foreach (var p2 in points)
                            {
                                if ((p2.col == chess.currentCol + (p.col - chess.currentCol) / 2) && (p2.row == chess.currentRow + (p.row - chess.currentRow) / 2))
                                {

                                    foreach (var c in listChess)
                                    {
                                        if (c.currentRow == p2.row && c.currentCol == p2.col && c.gameObject.activeSelf)
                                        {
                                            canMove = false;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    p.canMove = canMove;
                    DisplayPoint();
                }
                break;

            case (int)TypeChess.Rook:
                for (int i = chess.currentRow + 1; i <= 10; i++) // di len
                {
                    bool canMove = true;
                    bool isBlackChessFound = false;
                    foreach (var p in points)
                    {
                        if (p.col == chess.currentCol && p.row == i)
                        {
                            foreach (var c in listChess)
                            {
                                if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                {
                                    if (chess.GetColor() == c.GetColor())
                                    {
                                        canMove = false;
                                        break;
                                    }
                                    else if (chess.GetColor() != c.GetColor())
                                    {
                                        canMove = true;
                                        isBlackChessFound = true;
                                        break;
                                    }
                                }
                            }
                            p.canMove = canMove;
                            //DisplayPoint();
                        }
                    }
                    if (!canMove)
                    {
                        break;
                    }
                    if (isBlackChessFound)
                    {
                        break;
                    }
                }
                for (int i = chess.currentRow - 1; i >= 1; i--)  //di xuong
                {
                    bool canMove = true;
                    bool isBlackChessFound = false;
                    foreach (var p in points)
                    {
                        if (p.col == chess.currentCol && p.row == i)
                        {
                            foreach (var c in listChess)
                            {
                                if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                {
                                    if (chess.GetColor() == c.GetColor())
                                    {
                                        canMove = false;
                                        break;
                                    }
                                    else if (chess.GetColor() != c.GetColor())
                                    {
                                        canMove = true;
                                        isBlackChessFound = true;
                                        break;
                                    }
                                }
                            }

                            p.canMove = canMove;
                            //DisplayPoint();
                        }
                    }
                    if (!canMove)
                    {
                        break;
                    }
                    if (isBlackChessFound)
                    {
                        break;
                    }
                }
                for (int i = chess.currentCol + 1; i <= 9; i++)  //sang phai
                {
                    bool canMove = true;
                    bool isBlackChessFound = false;
                    foreach (var p in points)
                    {
                        if (p.col == i && p.row == chess.currentRow)
                        {
                            foreach (var c in listChess)
                            {
                                if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                {
                                    if (chess.GetColor() == c.GetColor())
                                    {
                                        canMove = false;
                                        break;
                                    }
                                    else if (chess.GetColor() != c.GetColor())
                                    {
                                        canMove = true;
                                        isBlackChessFound = true;
                                        break;
                                    }
                                }
                            }

                            p.canMove = canMove;
                            //DisplayPoint();
                        }
                    }
                    if (!canMove)
                    {
                        break;
                    }
                    if (isBlackChessFound)
                    {
                        break;
                    }
                }
                for (int i = chess.currentCol - 1; i >= 1; i--) //sang trai
                {
                    bool canMove = true;
                    bool isBlackChessFound = false;
                    foreach (var p in points)
                    {
                        if (p.col == i && p.row == chess.currentRow)
                        {
                            foreach (var c in listChess)
                            {
                                if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                {
                                    if (chess.GetColor() == c.GetColor())
                                    {
                                        canMove = false;
                                        break;
                                    }
                                    else if (chess.GetColor() != c.GetColor())
                                    {
                                        canMove = true;
                                        isBlackChessFound = true;
                                        break;
                                    }
                                }
                            }

                            p.canMove = canMove;
                            //DisplayPoint();
                        }
                    }
                    if (!canMove)
                    {
                        break;
                    }
                    if (isBlackChessFound)
                    {
                        break;
                    }
                }
                DisplayPoint();
                break;

            case (int)TypeChess.Knight:
                foreach (var p in points)
                {
                    if ((p.col == chess.currentCol + 1 && p.row == chess.currentRow + 2) ||
                       (p.col == chess.currentCol + 1 && p.row == chess.currentRow - 2) ||
                       (p.col == chess.currentCol - 1 && p.row == chess.currentRow + 2) ||
                       (p.col == chess.currentCol - 1 && p.row == chess.currentRow - 2) ||
                       (p.col == chess.currentCol + 2 && p.row == chess.currentRow + 1) ||
                       (p.col == chess.currentCol + 2 && p.row == chess.currentRow - 1) ||
                       (p.col == chess.currentCol - 2 && p.row == chess.currentRow + 1) ||
                       (p.col == chess.currentCol - 2 && p.row == chess.currentRow - 1))
                    {
                        bool canMove = true;
                        foreach (var c in listChess)
                        {
                            if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf && chess.GetColor() == c.GetColor())
                            {
                                canMove = false;
                                break;
                            }

                        }

                        foreach (var p2 in points)
                        {
                            if (p.col == chess.currentCol + 2 || p.col == chess.currentCol - 2)
                            {
                                if ((p2.col == chess.currentCol + (p.col - chess.currentCol) / 2) && (p2.row == chess.currentRow))
                                {

                                    foreach (var c in listChess)
                                    {
                                        if (c.currentRow == p2.row && c.currentCol == p2.col && c.gameObject.activeSelf)
                                        {
                                            canMove = false;
                                            break;
                                        }
                                    }
                                    /*foreach (var c in listChess)
                                    {
                                        if (c.currentRow == p2.row && c.currentCol == p2.col && c.gameObject.activeSelf)
                                        {
                                            canMove = false;
                                            break;
                                        }
                                    }*/
                                }
                            }
                            else if (p.row == chess.currentRow + 2 || p.row == chess.currentRow - 2)
                            {
                                if ((p2.col == chess.currentCol) && (p2.row == chess.currentRow + (p.row - chess.currentRow) / 2))
                                {

                                    foreach (var c in listChess)
                                    {
                                        if (c.currentRow == p2.row && c.currentCol == p2.col && c.gameObject.activeSelf)
                                        {
                                            canMove = false;
                                            break;
                                        }
                                    }
                                    /*foreach (var c in listChess)
                                    {
                                        if (c.currentRow == p2.row && c.currentCol == p2.col && c.gameObject.activeSelf)
                                        {
                                            canMove = false;
                                            break;
                                        }
                                    }*/
                                }
                            }
                        }
                        p.canMove = canMove;
                        //DisplayPoint();
                    }
                    else
                    {
                        p.canMove = false;
                        DisplayPoint();
                    }
                }
                break;

            case (int)TypeChess.Cannon:
                bool isBlockedByChessUp = false;
                bool isBlockedByChessDown = false;
                bool isBlockedByChessRight = false;
                bool isBlockedByChessLeft = false;
                for (int i = chess.currentRow + 1; i <= 10; i++) // di len
                {
                    bool canMove = true;
                    bool stop = false;
                    foreach (var p in points)
                    {
                        if (p.col == chess.currentCol && p.row == i)
                        {
                            if (isBlockedByChessUp)
                            {
                                canMove = false;
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                    {
                                        if (chess.GetColor() != c.GetColor())
                                        {
                                            canMove = true;

                                        }
                                        else if (chess.GetColor() == c.GetColor())
                                        {
                                            canMove = false;
                                        }
                                        stop = true;
                                        break;
                                    }
                                }
                                p.canMove = canMove;

                            }
                            else
                            {
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                    {
                                        canMove = false;
                                        stop = false;
                                        isBlockedByChessUp = true;
                                        break;
                                    }
                                }
                                p.canMove = canMove;
                            }
                        }
                        if (stop)
                        {
                            break;
                        }
                    }
                    if (stop)
                    {
                        break;
                    }

                }
                for (int i = chess.currentRow - 1; i >= 1; i--) // di xuong
                {
                    bool canMove = true;
                    bool stop = false;
                    foreach (var p in points)
                    {
                        if (p.col == chess.currentCol && p.row == i)
                        {
                            if (isBlockedByChessDown)
                            {
                                canMove = false;
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                    {
                                        if (chess.GetColor() != c.GetColor())
                                        {
                                            canMove = true;

                                        }
                                        else if (chess.GetColor() == c.GetColor())
                                        {
                                            canMove = false;
                                        }
                                        stop = true;
                                        break;
                                    }
                                }
                                p.canMove = canMove;

                            }
                            else
                            {
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                    {
                                        canMove = false;
                                        stop = false;
                                        isBlockedByChessDown = true;
                                        break;
                                    }
                                }
                                p.canMove = canMove;
                            }
                        }
                        if (stop)
                        {
                            break;
                        }
                    }
                    if (stop)
                    {
                        break;
                    }
                }
                for (int i = chess.currentCol + 1; i <= 9; i++) // sang phai
                {
                    bool canMove = true;
                    bool stop = false;
                    foreach (var p in points)
                    {
                        if (p.col == i && p.row == chess.currentRow)
                        {
                            if (isBlockedByChessRight)
                            {
                                canMove = false;
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                    {
                                        if (chess.GetColor() != c.GetColor())
                                        {
                                            canMove = true;

                                        }
                                        else if (chess.GetColor() == c.GetColor())
                                        {
                                            canMove = false;
                                        }
                                        stop = true;
                                        break;
                                    }
                                }
                                p.canMove = canMove;

                            }
                            else
                            {
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                    {
                                        canMove = false;
                                        stop = false;
                                        isBlockedByChessRight = true;
                                        break;
                                    }
                                }
                                p.canMove = canMove;
                            }
                        }
                        if (stop)
                        {
                            break;
                        }
                    }
                    if (stop)
                    {
                        break;
                    }
                }
                for (int i = chess.currentCol - 1; i >= 1; i--) // sang trai
                {
                    bool canMove = true;
                    bool stop = false;
                    foreach (var p in points)
                    {
                        if (p.col == i && p.row == chess.currentRow)
                        {
                            if (isBlockedByChessLeft)
                            {
                                canMove = false;
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                    {
                                        if (chess.GetColor() != c.GetColor())
                                        {
                                            canMove = true;

                                        }
                                        else if (chess.GetColor() == c.GetColor())
                                        {
                                            canMove = false;
                                        }
                                        stop = true;
                                        break;
                                    }
                                }
                                p.canMove = canMove;

                            }
                            else
                            {
                                foreach (var c in listChess)
                                {
                                    if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf)
                                    {
                                        canMove = false;
                                        stop = false;
                                        isBlockedByChessLeft = true;
                                        break;
                                    }
                                }
                                p.canMove = canMove;
                            }
                        }
                        if (stop)
                        {
                            break;
                        }
                    }
                    if (stop)
                    {
                        break;
                    }
                }
                DisplayPoint();
                break;

            case (int)TypeChess.Pawn:
                int direct = 1;
                if (chess.GetColor() == (int)ColorChess.Red)
                {
                    direct = 1;
                }
                else if (chess.GetColor() == (int)ColorChess.Black)
                {
                    direct = -1;
                }
                foreach (var p in points)
                {
                    if (p.col == chess.currentCol && p.row == chess.currentRow + direct ||
                        (p.col == chess.currentCol + 1 && p.row == chess.currentRow && ((chess.GetColor() == (int)ColorChess.Red && p.row >= 6) || (chess.GetColor() == (int)ColorChess.Black && p.row <= 5))) ||
                        (p.col == chess.currentCol - 1 && p.row == chess.currentRow && ((chess.GetColor() == (int)ColorChess.Red && p.row >= 6) || (chess.GetColor() == (int)ColorChess.Black && p.row <= 5))))
                    {
                        bool canMove = true;
                        foreach (var c in listChess)
                        {
                            if (c.currentRow == p.row && c.currentCol == p.col && c.gameObject.activeSelf && chess.GetColor() == c.GetColor())
                            {
                                canMove = false;
                                break;
                            }
                        }
                        p.canMove = canMove;
                        DisplayPoint();
                    }
                    else
                    {
                        p.canMove = false;
                        DisplayPoint();
                    }
                }
                break;
            default:
                break;
        }
    }

    public void DisplayPoint()
    {
        foreach (var p in points)
        {
            p.DisplayPointCanMove(p.canMove);
        }
    }

    public void ResetCanMove()
    {
        foreach (var p in points)
        {
            p.canMove = false;
        }
    }

    public void ResetValuePoint()
    {
        foreach (var p in points)
        {
            p.value = 0;
        }
    }
}
