using UnityEngine;

public class Scale : MonoBehaviour
{
    public float scaleSpeed = 1f; // Speed of scaling
    public float maxScale = 2f; // Maximum allowed scale
    public float minScale = -2f; // Minimum allowed scale
    private bool shrinking = false;

    void Update()
    {
        Vector3 newScale = transform.localScale;

        if (!shrinking)
        {
            newScale.y += scaleSpeed * Time.deltaTime;
            if (newScale.y >= maxScale)
            {
                newScale.y = maxScale;
                shrinking = true;
            }
        }
        else
        {
            newScale.y -= scaleSpeed * Time.deltaTime;
            if (newScale.y <= minScale)
            {
                newScale.y = minScale;
                shrinking = false;
            }
        }

        transform.localScale = newScale;
    }
}