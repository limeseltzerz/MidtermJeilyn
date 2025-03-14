using UnityEngine;

public class ScaleRight : MonoBehaviour
{
    public float minScaleX = 1f; 
    public float maxScaleX = 3f; 
    public float speed = 2f; 

    private bool scalingUp = true;

    void Update()
    {
       
        float scaleChange = speed * Time.deltaTime;
        float newScaleX = transform.localScale.x + (scalingUp ? scaleChange : -scaleChange);

      
        if (newScaleX >= maxScaleX)
        {
            newScaleX = maxScaleX;
            scalingUp = false; 
        }
        else if (newScaleX <= minScaleX)
        {
            newScaleX = minScaleX;
            scalingUp = true; 
        }

        transform.localScale = new Vector3(newScaleX, transform.localScale.y, transform.localScale.z);
    }
}