using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class CubeDestroy : MonoBehaviour
{
    public GameObject destroyCube;


    private void OnTriggerEnter(Collider other)
    {
        Analytics.CustomEvent("cube Gone");
        Destroy(gameObject);
    }

}
