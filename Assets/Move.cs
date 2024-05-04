using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Rover;
    public GameObject vila;

    public GameObject lever1;
    public GameObject lever2;

    private Vector2 R1;
    private float R2;
    private float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        R1 = new Vector2(lever1.transform.localPosition.x, lever1.transform.localPosition.z);
        R2 = lever2.transform.localPosition.x;

        if (R1.x > 1) R1.x = 1;
        if (R1.x < -1) R1.x = -1;
        if (R1.y > 1) R1.y = 1;
        if (R1.y < -1) R1.y = -1;
        if (R2 > 1) R2 = 1;
        if (R2 < -1) R2 = -1;
        lever1.transform.localPosition = new Vector3(R1.x, 0, R1.y);
        lever2.transform.localPosition = new Vector3(R2, 0, 0);
        if (Mathf.Abs(R1.x) < 0.1) R1.x = 0;
        if (Mathf.Abs(R1.y) < 0.1) R1.y = 0;
        speed += R1.y * Time.deltaTime;
        if (speed > 3) speed = 3;
        if (speed < -3) speed = -3;
        Rover.transform.position += Time.deltaTime * Rover.transform.forward * speed;
        Rover.transform.rotation *= Quaternion.Euler(0, R1.x * speed * 15 * Time.deltaTime, 0);
        vila.transform.localPosition = new Vector3(0, 20*R2, 0);
    }
}
