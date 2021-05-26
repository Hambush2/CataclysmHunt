using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    static public bool active;
    public float tick;
    public int seconds;
    public int minutes;
    string minStr;
    string secStr;
    public static string time;
    // Start is called before the first frame update
    void Start()
    {
        tick = 0;
        seconds = 0;
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (active)
        {
            tick += 0.02f;
            if (tick >= 1)
            {
                seconds++;
                tick = 0;
            }
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes.ToString().Length < 2)
            {
                minStr = "0" + minutes;
            }
            else
            {
                minStr = minutes.ToString();
            }
            if (seconds.ToString().Length < 2)
            {
                secStr = "0" + seconds;
            }
            else
            {
                secStr = seconds.ToString();
            }
            time = minStr + ":" + secStr;

            this.gameObject.GetComponent<TextMesh>().text = time;
        }
    }
}
