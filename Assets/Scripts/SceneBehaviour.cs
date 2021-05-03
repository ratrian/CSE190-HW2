using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehaviour : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            if (SceneManager.GetActiveScene().name == "FoV")
            {
                SceneManager.LoadScene("Spatial Resolution");
            }
            else if (SceneManager.GetActiveScene().name == "Spatial Resolution")
            {
                SceneManager.LoadScene("Controller Tracking Precision");
            }
            else if (SceneManager.GetActiveScene().name == "Controller Tracking Precision")
            {
                SceneManager.LoadScene("Controller Pointer Precision");
            }
            else if (SceneManager.GetActiveScene().name == "Controller Pointer Precision")
            {
                SceneManager.LoadScene("Closest Eye Convergence Distance");
            }
            else if (SceneManager.GetActiveScene().name == "Closest Eye Convergence Distance")
            {
                SceneManager.LoadScene("FoV");
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            if (SceneManager.GetActiveScene().name == "FoV")
            {
                SceneManager.LoadScene("Closest Eye Convergence Distance");
            }
            else if (SceneManager.GetActiveScene().name == "Spatial Resolution")
            {
                SceneManager.LoadScene("FoV");
            }
            else if (SceneManager.GetActiveScene().name == "Controller Tracking Precision")
            {
                SceneManager.LoadScene("Spatial Resolution");
            }
            else if (SceneManager.GetActiveScene().name == "Controller Pointer Precision")
            {
                SceneManager.LoadScene("Controller Tracking Precision");
            }
            else if (SceneManager.GetActiveScene().name == "Closest Eye Convergence Distance")
            {
                SceneManager.LoadScene("Controller Pointer Precision");
            }
        }
    }
}
