using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam : MonoBehaviour
{
    float length;
    public int numHits;

    // Start is called before the first frame update
    void Start()
    {
        length = 11.0f;
        numHits = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, CalculateEnd());
    }

    Vector3 CalculateEnd()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit);
        Vector3 endPosition = transform.position + transform.forward * length;
        if (hit.collider)
        {
            endPosition = hit.point;
            if (hit.collider.gameObject.name == "Sphere")
            {
                if (hit.collider.gameObject.GetComponent<MeshRenderer>().material.color != Color.white)
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                    if (GameObject.Find("Timer").GetComponent<TimerBehaviour>().timeIsRunning)
                    {
                        numHits++;
                        GameObject.Find("Counter").GetComponent<UnityEngine.UI.Text>().text = "# of Hits: " + numHits.ToString();
                    }
                }
            }
        }
        else
        {
            GameObject.Find("Sphere").GetComponent<MeshRenderer>().material.color = Color.red;
        }
        return endPosition;
    }
}