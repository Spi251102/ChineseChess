using UnityEngine;


public enum TypeChess
{
    Chancellor = 0,
    Guard = 1,
    Elephant = 2,
    Rook = 3,
    Knight = 4,
    Cannon = 5,
    Pawn = 6
}

public enum ColorChess
{
    Black = 0,
    Red
}

public class Chess : MonoBehaviour
{
    public Transform tf;
    [SerializeField] TypeChess typeChess;
    [SerializeField] ColorChess color;
    public int value;
    public int currentCol;
    public int currentRow;


    public int GetTypeChess()
    {
        return (int)typeChess;
    }

    public int GetColor()
    {
        return (int)color;
    }

}
