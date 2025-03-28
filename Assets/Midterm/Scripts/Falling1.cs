using UnityEngine;

public class FallingDamage : MonoBehaviour
{
    public float gravityScale = 1f; // custom gravity scale
    private Rigidbody2D rb;
    public float dropTime = 12f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // setting custom gravity blehhh

        Invoke("DropObject", dropTime);
    }
 void DropObject()
    {
        rb.gravityScale = gravityScale;
    }
}

    

