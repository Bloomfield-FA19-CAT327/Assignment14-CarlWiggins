using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Sound : MonoBehaviour
{
    public AudioSource poof;

    // Start is called before the first frame update
    public void soundStart()
    {
        Analytics.CustomEvent("played song");
       poof.Play();
    }

}
 
