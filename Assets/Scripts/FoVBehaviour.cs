using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoVBehaviour : MonoBehaviour
{
    float height, width;
    float verticalFoV, horizontalFoV, diagonalFoV;

    // Start is called before the first frame update
    void Start()
    {
        height = 1.725828f;
        width = 1.228261f;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (OVRInput.Get(OVRInput.Button.One))
        {
            verticalFoV = 2.0f * (Mathf.Atan((height / 2.0f) / Mathf.Abs(transform.position.x)) * 180.0f / Mathf.PI);
            GameObject.Find("Vertical FoV").GetComponent<UnityEngine.UI.Text>().text = "Vertical FoV: " + verticalFoV.ToString();
        }
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            horizontalFoV = 2.0f * (Mathf.Atan((width / 2.0f) / Mathf.Abs(transform.position.x)) * 180.0f / Mathf.PI);
            GameObject.Find("Horizontal FoV").GetComponent<UnityEngine.UI.Text>().text = "Horizontal FoV: " + horizontalFoV.ToString();
        }
        if (OVRInput.Get(OVRInput.Button.Three))
        {
            diagonalFoV = Mathf.Sqrt(verticalFoV * verticalFoV + horizontalFoV * horizontalFoV);
            GameObject.Find("Diagonal FoV").GetComponent<UnityEngine.UI.Text>().text = "Diagonal FoV: " + diagonalFoV.ToString();
        }
    }
}
