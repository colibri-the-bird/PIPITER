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
        s_coord += 5 + 175/2f;
        for (int i = 0; i < 10; i++) 
        {
            Instantiate(spawnlevel[Random.Range(0, spawnlevel.Length)], new Vector3(-5, -14, s_coord), Quaternion.identity);
            s_coord += 175;
        }
    }
}
