using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public GameObject targetText;
    bool close;
    public GameObject Pickups;
    AudioSource bgm;
    // Start is called before the first frame update
    void Start()
    {
        close = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(close && Input.GetKeyDown("e"))
        {
            Timer.active = true;
            targetText.GetComponent<TextMesh>().text = "Collect all the capsules as quick as you can!";
            Pickups.SetActive(true);
            bgm.Play();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            close = true;
            targetText.SetActive(true);
            targetText.GetComponent<TextMesh>().text = "Press E to Begin";
            bgm = other.gameObject.GetComponent<AudioSource>();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(Timer.active == true && other.gameObject.tag == "Player")
        {
            targetText.SetActive(false);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            close = false;
            targetText.SetActive(false);
        }
    }
}
