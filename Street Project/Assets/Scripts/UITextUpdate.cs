using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITextUpdate : MonoBehaviour
{
    public GameObject Pickups;
    GameObject[] pickups;
    public GameObject gameText;
    public GameObject finTime;
    public GameObject prompt;
    int max;
    // Start is called before the first frame update
    void Start()
    {
        max = GameObject.FindGameObjectsWithTag("Pickups").Length;
        this.gameObject.GetComponent<TextMesh>().text = "Collected: 0/" + max;
        Pickups.SetActive(false);
        gameText.SetActive(false);
        finTime.SetActive(false);
        prompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Pickups.activeSelf == true)
        {
            pickups = GameObject.FindGameObjectsWithTag("Pickups");
            this.gameObject.GetComponent<TextMesh>().text = "Collected: " + (max - pickups.Length) + "/" + max;

        }
        if (pickups.Length == 0)
        {
            Timer.active = false;
            gameText.SetActive(true);
            finTime.SetActive(true);
            prompt.SetActive(true);
            finTime.GetComponent<TextMesh>().text = "Time:" + System.Environment.NewLine + Timer.time;
            prompt.GetComponent<TextMesh>().text = "Press X to restart";
            if (Input.GetKeyDown("x"))
            {
                SceneManager.LoadScene("Game");
            }
        }
    }
}
