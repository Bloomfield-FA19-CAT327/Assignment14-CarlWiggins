using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource poof;

    // Start is called before the first frame update
    public void soundStart()
    {
        poof.Play();
    }

}
 
