using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class CoinScript : MonoBehaviour

{
    public AudioSource source;
    public AudioClip clip;
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()

    {
        source.PlayOneShot(clip);
        //This destroys the coin
        Destroy(gameObject);
        



    }
}
