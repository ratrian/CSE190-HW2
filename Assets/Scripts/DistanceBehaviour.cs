using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBehaviour : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            GameObject.Find("Distance").GetComponent<UnityEngine.UI.Text>().text = "Distance: " + Mathf.Abs(transform.position.z).ToString();
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            GameObject.Find("Distance").GetComponent<UnityEngine.UI.Text>().text = "Distance: " + Mathf.Abs(transform.position.z).ToString();
        }
        
    }
}