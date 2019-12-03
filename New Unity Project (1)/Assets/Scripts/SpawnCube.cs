using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class SpawnCube : MonoBehaviour
{

    public Transform spawnPos;
    public GameObject cube;

    // Start is called before the first frame update
   public void spawnCube()
    {
        Analytics.CustomEvent("spawned cube");
         Instantiate(cube, spawnPos.transform.position, Quaternion.identity);
    }
   
}
