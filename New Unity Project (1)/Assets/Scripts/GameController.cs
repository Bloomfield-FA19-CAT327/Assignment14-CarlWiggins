using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameController : MonoBehaviour
{
    public Button buttons1;
    public Button buttons2;
    public Button buttons3;

    public GameObject cube;
    public Transform spawnPos;


    public ParticleSystem particle;
    public AudioSource poof;





    public void buttonEvents()
    {
        if (gameObject.CompareTag("button1"))
        {
            particle.enableEmission  = false;
            particle.Play();
        }

        if (gameObject.CompareTag("button2"))
        {
            Instantiate(cube, spawnPos.transform.position,Quaternion.identity);
        }

         if (gameObject.CompareTag("button3"))
        {
            poof.Play();
        }
 

    }
}
