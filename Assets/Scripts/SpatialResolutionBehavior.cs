using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialResolutionBehavior : MonoBehaviour
{
    float x;
    float verticalSpatialResolution, horizontalSpatialResolution;

    // Start is called before the first frame update
    void Start()
    {
        x = 0.003f;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            GameObject.Find("Vertical Lines").transform.Translate(Vector3.forward * Time.deltaTime);
            verticalSpatialResolution = Mathf.Sqrt(GameObject.Find("Vertical Lines").transform.position.y * GameObject.Find("Vertical Lines").transform.position.y + GameObject.Find("Vertical Lines").transform.position.z * GameObject.Find("Vertical Lines").transform.position.z) * Mathf.Tan(Mathf.PI / 180.0f) / x;
            GameObject.Find("Vertical Spatial Resolution").GetComponent<UnityEngine.UI.Text>().text = "Vertical Spatial Resolution: " + verticalSpatialResolution.ToString();
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            GameObject.Find("Horizontal Lines").transform.Translate(Vector3.forward * Time.deltaTime);
            horizontalSpatialResolution = Mathf.Sqrt(GameObject.Find("Horizontal Lines").transform.position.y * GameObject.Find("Horizontal Lines").transform.position.y + GameObject.Find("Horizontal Lines").transform.position.z * GameObject.Find("Horizontal Lines").transform.position.z) * Mathf.Tan(Mathf.PI / 180.0f) / x;
            GameObject.Find("Horizontal Spatial Resolution").GetComponent<UnityEngine.UI.Text>().text = "Horizontal Spatial Resolution: " + horizontalSpatialResolution.ToString();
        }
    }
}
