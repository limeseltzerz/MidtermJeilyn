using UnityEngine;

public class SoundEffect : MonoBehaviour

{
    public AudioSource source;
    public AudioClip clip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collider Collide)
    {
        source.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
