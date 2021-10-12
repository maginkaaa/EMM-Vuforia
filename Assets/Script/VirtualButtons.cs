using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtons : MonoBehaviour
{

    [SerializeField]
    public Transform catLady;
    float rotationSpeed = 40.0f;
    //public GameObject catLady;
    //Rigidbody crazyCatLady;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    private float playerSpeed = 1.0f;
    //private float angle = 0;
    bool isButtonOnePressed = false;
    bool isButtonTwoPressed = false;
    bool isButtonThreePressed = false;
    bool isButtonFourPressed = false;


    // Start is called before the first frame update
    void Start()
    {
        
        isButtonOnePressed = false;

        //crazyCatLady = GetComponent<Rigidbody>();
        button1 = GameObject.Find("button1");
        button2 = GameObject.Find("button2");
        button3 = GameObject.Find("button3");
        button4 = GameObject.Find("button4");

        button1.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button1.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        button2.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button2.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        button3.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button3.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        button4.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button4.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    void Update()
    {
        Debug.Log(isButtonOnePressed);
        if (isButtonOnePressed == true)
        {
            catLady.transform.position += playerSpeed * catLady.transform.forward;
            //catLady.transform.position += playerSpeed * catLady.transform.forward;
            //catLady.GetComponent<Rigidbody>().velocity += Time.deltaTime * playerSpeed * transform.forward;
            Debug.Log("1");
        }
        else if (isButtonTwoPressed == true)
        {
            catLady.transform.position += playerSpeed * -catLady.transform.forward;
            //catLady.GetComponent<Rigidbody>().velocity += Time.deltaTime * playerSpeed * -transform.forward;
            Debug.Log("2");
        }

        else if (isButtonThreePressed == true)
        {
            catLady.transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * rotationSpeed, Space.Self);
            Debug.Log("3");
        }

        else if (isButtonFourPressed == true)
        {
            catLady.transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * rotationSpeed, Space.Self);
            Debug.Log("4");
        }


    }
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("test");
        switch (vb.VirtualButtonName)
        {

            //up
            case "button1":
                isButtonOnePressed = true;
                break;
            //down
            case "button2":
                isButtonTwoPressed = true;
                break;
            //left
            case "button3":
                isButtonThreePressed = true;
                break;
            //right
            case "button4":
                isButtonFourPressed = true;
                break;
        }

    }
    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            //up
            case "button1":
                isButtonOnePressed = false;
                break;
            //down
            case "button2":
                isButtonTwoPressed = false;
                break;
            //left
            case "button3":
                isButtonThreePressed = false;
                break;
            //right
            case "button4":
                isButtonFourPressed = false;
                break;
        }

    }

}