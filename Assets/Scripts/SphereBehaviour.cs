using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            GameObject.Find("Laser Beam").GetComponent<LaserBeam>().numHits = 0;
            GameObject.Find("Counter").GetComponent<UnityEngine.UI.Text>().text = "# of Hits: " + GameObject.Find("Laser Beam").GetComponent<LaserBeam>().numHits.ToString();
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            GameObject.Find("Laser Beam").GetComponent<LaserBeam>().numHits = 0;
            GameObject.Find("Counter").GetComponent<UnityEngine.UI.Text>().text = "# of Hits: " + GameObject.Find("Laser Beam").GetComponent<LaserBeam>().numHits.ToString();
        }
    }
}
