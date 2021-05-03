using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBehaviour : MonoBehaviour
{
    float fiveSeconds;
    int num;
    float sumOfPosX, sumOfSquaresOfPosX;
    float sumOfPosY, sumOfSquaresOfPosY;
    float sumOfPosZ, sumOfSquaresOfPosZ;
    float sumOfRotW, sumOfSquaresOfRotW;
    float sumOfRotX, sumOfSquaresOfRotX;
    float sumOfRotY, sumOfSquaresOfRotY;
    float sumOfRotZ, sumOfSquaresOfRotZ;

    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        sumOfSquaresOfPosX = 0.0f;
        sumOfSquaresOfPosY = 0.0f;
        sumOfSquaresOfPosZ = 0.0f;
        sumOfSquaresOfRotW = 0.0f;
        sumOfSquaresOfRotX = 0.0f;
        sumOfSquaresOfRotY = 0.0f;
        sumOfSquaresOfRotZ = 0.0f;

        fiveSeconds = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.FloorToInt(fiveSeconds) == 5)
        {
            float averagePosX = sumOfPosX / (float)num;
            float sdPosX = Mathf.Sqrt(sumOfSquaresOfPosX / ((float)num - 1.0f));
            float averagePosY = sumOfPosY / (float)num;
            float sdPosY = Mathf.Sqrt(sumOfSquaresOfPosY / ((float)num - 1.0f));
            float averagePosZ = sumOfPosZ / (float)num;
            float sdPosZ = Mathf.Sqrt(sumOfSquaresOfPosZ / ((float)num - 1.0f));
            float averageRotW = sumOfRotW / (float)num;
            float sdRotW = Mathf.Sqrt(sumOfSquaresOfRotW / ((float)num - 1.0f));
            float averageRotX = sumOfRotX / (float)num;
            float sdRotX = Mathf.Sqrt(sumOfSquaresOfRotX / ((float)num - 1.0f));
            float averageRotY = sumOfRotY / (float)num;
            float sdRotY = Mathf.Sqrt(sumOfSquaresOfRotY / ((float)num - 1.0f));
            float averageRotZ = sumOfRotZ / (float)num;
            float sdRotZ = Mathf.Sqrt(sumOfSquaresOfRotZ / ((float)num - 1.0f));

            GameObject.Find("Controller Position").GetComponent<UnityEngine.UI.Text>().text = "Controller Position:\nx=" + averagePosX.ToString() + ",y=" + averagePosY.ToString() + ",z=" + averagePosZ.ToString();
            GameObject.Find("Controller Position SD").GetComponent<UnityEngine.UI.Text>().text = "Controller Position SD:\nx=" + sdPosX.ToString() + ",y=" + sdPosY.ToString() + ",z=" + sdPosZ.ToString(); ;
            GameObject.Find("Controller Orientation").GetComponent<UnityEngine.UI.Text>().text = "Controller Orientation:\nw=" + averageRotW.ToString() + ",x=" + averageRotX.ToString() + ",y=" + averageRotY.ToString() + ",z=" + averageRotZ.ToString();
            GameObject.Find("Controller Orientation SD").GetComponent<UnityEngine.UI.Text>().text = "Controller Orientation SD:\nw=" + sdRotW.ToString() + ",x=" + sdRotX.ToString() + ",y=" + sdRotY.ToString() + ",z=" + sdRotZ.ToString();
        }
        else
        {
            fiveSeconds += Time.deltaTime;

            num += 1;
            sumOfPosX += OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).x;
            sumOfSquaresOfPosX += OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).x * OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).x;
            sumOfPosY += OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).y;
            sumOfSquaresOfPosY += OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).y * OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).y;
            sumOfPosZ += OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).z;
            sumOfSquaresOfPosZ += OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).z * OVRInput.GetLocalControllerPosition(OVRInput.Controller.LHand).z;
            sumOfRotW += OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).w;
            sumOfSquaresOfRotW += OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).w * OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).w;
            sumOfRotX += OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).x;
            sumOfSquaresOfRotX += OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).x * OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).x;
            sumOfRotY += OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).y;
            sumOfSquaresOfRotY += OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).y * OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).y;
            sumOfRotZ += OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).z;
            sumOfSquaresOfRotZ += OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).z * OVRInput.GetLocalControllerRotation(OVRInput.Controller.LHand).z;
        }
    }
}
