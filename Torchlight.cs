using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torchlight : MonoBehaviour
{
    private Light flashlight;
    private float battery;
    private float fullBattery;

    private bool isOn = false;

    void Start()
    {
        flashlight = GetComponent<Light>();
        fullBattery = battery;
    }

    void Update()
    {
        //if (Input.GetButtonDown("Toggle Flashlight"))
        //{
        //    isOn = !isOn;
        //    if (isOn == true)
        //    {
        //       flashlight.intensity = 1;
        //    }
        //    else if (battery <= 0)
        //    {
        //        isOn = false;
        //        flashlight.intensity = 0;
        //    }
        //    else
        //    {
        //        isOn = false;
        //        flashlight.intensity = 0;
        //    }
        //}
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Battery" || collision.collider.tag == "Battery")
        {
            battery = fullBattery;
        }
    }
}