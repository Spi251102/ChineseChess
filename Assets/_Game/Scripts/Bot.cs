using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    [SerializeField] ColorChess color;
    GameManager gameManager;
    ChessSpawner chessSpawner;
    List<Chess> listBlackChess;
    List<Point> points;

    private void Start()
    {
        gameManager = GameManager.instance;
        chessSpawner = ChessSpawner.instance;
        listBlackChess = new List<Chess>();
        points = new List<Point>();
    }

    private void Update()
    {
        Play();
    }

    public Point SelectPointMaxValue(List<Point> points)
    {
        points.Clear();
        Point point = null;
        foreach (var p in chessSpawner.points)
        {
            if (p.canMove)
            {
                foreach (var c in chessSpawner.listChess)
                {
                    if (c.currentCol == p.col && c.currentRow == p.row && c.gameObject.activeSelf && c.GetColor() == (int)ColorChess.Red)
                    {
                        p.value += c.value;

                    }
                }
                points.Add(p);

            }
        }
        Debug.Log("points.count = " + points.Count);
        int max = 0;
        foreach (var p in points)
        {
            if (p.value >= max)
            {
                max = p.value;
                point = p;
            }
        }
        //Debug.Log(point.gameObject.activeSelf);
        return point;
    }

    public Chess SelectChessMaxValue(List<Chess> listBlackChess)
    {
        //List<Chess> listBlackChess;
        listBlackChess.Clear();
        Chess chess = null;

        foreach (var c in chessSpawner.listChess)
        {
            if (c.GetColor() == (int)ColorChess.Black && c.gameObject.activeSelf)
            {
                listBlackChess.Add(c);
            }
        }
        int max = 0;
        for (int i = 0; i < listBlackChess.Count; i++)
        {
            chessSpawner.CheckCanMove(listBlackChess[i]);
            Point point = SelectPointMaxValue(points);
            if (point != null)
            {
                if (point.value >= max)
                {
                    max = point.value;
                    chess = listBlackChess[i];
                }
            }
            chessSpawner.ResetCanMove();
            chessSpawner.ResetValuePoint();
        }
        Debug.Log("Chess: " + chess.GetTypeChess() + " vi tri: " + chess.currentCol + " " + chess.currentRow);
        return chess;
    }

    public void Play()
    {
        if (!gameManager.turnRed)
        {
            Chess chess = RamdomChess(listBlackChess);
            while (chess == null)
            {
                chess = RamdomChess(listBlackChess);
            }
            chessSpawner.CheckCanMove(chess);
            //Point point = RamdomPoint(points);
            Point point = SelectPointMaxValue(points);
            chessSpawner.MoveToPoint(chess, point);
            if (point != null)
            {
                chessSpawner.ResetValuePoint();
            }
            gameManager.turnRed = true;
        }
    }

    public void CheckPoint()
    {
        foreach (var c in chessSpawner.listChess)
        {
            if (c.GetColor() == (int)color)
            {
                chessSpawner.CheckCanMove(c);

            }

        }
    }

    public Chess RamdomChess(List<Chess> listBlackChess)
    {
        //List<Chess> listBlackChess;
        listBlackChess.Clear();
        Chess chess = null;

        foreach (var c in chessSpawner.listChess)
        {
            if (c.GetColor() == (int)ColorChess.Black && c.gameObject.activeSelf)
            {
                listBlackChess.Add(c);
            }
        }
        int ramdom = Random.Range(0, listBlackChess.Count);
        for (int i = 0; i < listBlackChess.Count; i++)
        {
            if (i == ramdom)
            {
                chess = listBlackChess[i];
            }
        }
        Debug.Log("Chess: " + chess.GetTypeChess() + " vi tri: " + chess.currentCol + " " + chess.currentRow);
        return chess;
    }

    public Point RamdomPoint(List<Point> points)
    {
        points.Clear();
        Point point = null;
        foreach (var p in chessSpawner.points)
        {
            if (p.canMove)
            {
                points.Add(p);
            }
        }
        int ramdom = Random.Range(0, points.Count);
        for (int i = 0; i < points.Count; i++)
        {
            if (i == ramdom)
            {
                point = points[i];
            }
        }
        return point;
    }
}
