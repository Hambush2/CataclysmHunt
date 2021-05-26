using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catclysm : MonoBehaviour
{
    public float cataForce;
    public static int forceDirection;
    public Vector3 start;
    public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();
        forceDirection = rand.Next(1,3);
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.active)
        {
            switch (forceDirection)
            {
                case 1:
                    transform.Translate(cataForce, 0, 0);
                    break;
                case 2:
                    transform.Translate(0, 0, cataForce);
                    break;
            }

            if (transform.position.y < ((floor.transform.position.y) - 15))
            {
                transform.position = start;
            }
        }

    }
}
