using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBehaviour : MonoBehaviour
{
    float timeRemaining;
    public bool timeIsRunning;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = 21.0f;
        timeIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) || (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)))
        {
            timeRemaining = 21.0f;
            timeIsRunning = true;
        }

        if (timeIsRunning)
        {
            GetComponent<UnityEngine.UI.Text>().text = "Time Remaining: " + Mathf.FloorToInt(timeRemaining).ToString();
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0.0f)
            {
                GetComponent<UnityEngine.UI.Text>().text = "Time is up!";
                timeRemaining = 0.0f;
                timeIsRunning = false;
            }
        }
    }
}
