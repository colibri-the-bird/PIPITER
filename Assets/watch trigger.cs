using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchtrigger : MonoBehaviour
{
        private watch watch;
        private void Start()
        {
            watch = GameObject.FindObjectOfType<watch>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                watch.action = null;
            }
        }
}
