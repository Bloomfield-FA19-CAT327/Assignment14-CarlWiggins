using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class SpawnParticle : MonoBehaviour
{
    public ParticleSystem particle;
    // Start is called before the first frame update

    private void Start()
    {
        particle.enableEmission = false;
    }

    public void play()
    {
        particle.enableEmission = true;
        particle.Play();
    }

}
