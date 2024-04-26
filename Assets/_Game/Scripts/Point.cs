using UnityEngine;

public class Point : MonoBehaviour
{
    public int col;
    public int row;
    public int value;
    [SerializeField] private SpriteRenderer spriteRenderer;
    public Transform tf;

    public bool canMove;

    private void Start()
    {
        //Color color = spriteRenderer.material.color;
        canMove = false;
        DisplayPointCanMove(canMove);
    }

    public void DisplayPointCanMove(bool canMove)
    {
        if (canMove)
        {
            tf.position = new Vector3(tf.position.x, tf.position.y, -3);
            spriteRenderer.material.color = new(spriteRenderer.material.color.r, spriteRenderer.material.color.g, spriteRenderer.material.color.b, 1f);
        }
        else
        {
            //spriteRenderer.enabled = false;
            tf.position = new Vector3(tf.position.x, tf.position.y, -1);
            spriteRenderer.material.color = new(spriteRenderer.material.color.r, spriteRenderer.material.color.g, spriteRenderer.material.color.b, 0f);

        }
    }
}
