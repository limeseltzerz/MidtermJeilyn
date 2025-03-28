using UnityEngine;

public class ScaleUpDown : MonoBehaviour
{
    public float minScaleY = 1f; 
    public float maxScaleY = 2f; 
    public float speed = 2f; 

    private bool scalingUp = true; 

    void Update()
    {
       
        float scaleChange = speed * Time.deltaTime;
        float newScaleY = transform.localScale.y + (scalingUp ? scaleChange : -scaleChange);

        
        if (newScaleY >= maxScaleY)
        {
            newScaleY = maxScaleY;
            scalingUp = false;
        }
        else if (newScaleY <= minScaleY)
        {
            newScaleY = minScaleY;
            scalingUp = true;
        }

        
        transform.localScale = new Vector3(transform.localScale.x, newScaleY, transform.localScale.z);
    }
}
