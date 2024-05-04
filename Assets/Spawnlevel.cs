using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnlevel : MonoBehaviour
{
    public GameObject[] spawnlevel;
    private float s_coord;
    // Start is called before the first frame update
    void Start()
    {
        s_coord += 5 + spawnlevel[0].transform.localScale.z/2;
        for (int i = 0; i < 10; i++) 
        {
            Instantiate(spawnlevel[Random.Range(0, 10)], new Vector3(0, 0, s_coord), Quaternion.identity);
            s_coord += spawnlevel[0].transform.localScale.z;
        }
    }
}
