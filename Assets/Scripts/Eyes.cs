using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    private Camera eyes;
    private float defaultFOV; 
    // Start is called before the first frame update
    void Start()
    {
        eyes = GetComponent<Camera>();
        defaultFOV = eyes.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Zoom"))
        {
            eyes.fieldOfView = defaultFOV / 2f;
        } else
        {
            eyes.fieldOfView = defaultFOV;
        }
    }
}
