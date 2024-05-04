using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float Hp = 1000;
    public GameObject Defeat;
    public bool _defeat;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Hp <= 0)&&!_defeat)
        {
            Defeat.SetActive(true);
            _defeat = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Uron")
        {
            Hp -= 100;
        }
    }
}
