using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2f; 
    public float moveDistance = 3f; 

    private Vector3 startPosition;
    private int direction = 1; // 1 = right, -1 = left

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
        if (Mathf.Abs(transform.position.x - startPosition.x) >= moveDistance)
        {
            direction *= -1;
        }
    }
}