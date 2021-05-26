using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            System.Random random = new System.Random();
            Catclysm.forceDirection = random.Next(1, 3);
            other.GetComponents<AudioSource>()[1].Play();
            Destroy(gameObject);
        }
    }
}
