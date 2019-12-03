using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroy : MonoBehaviour
{
    public GameObject destroyCube;


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
