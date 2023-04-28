using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleMovement : MonoBehaviour
{
    public Material stationaryMaterial;
    public Material leftMaterial;
    public Material rightMaterial;
    public PickUpCandle PickUpCandle;

    private void Start()
    {
        PickUpCandle = GameObject.Find("Candle").GetComponent<PickUpCandle>();
    }

    private void Update()
    {
        if (PickUpCandle.equipped == true)
        {
            if (Input.GetKey(KeyCode.A)) // If the A key is pressed
            {
                GetComponent<Renderer>().material = rightMaterial;
            }
            else if (Input.GetKey(KeyCode.D)) // If the D key is pressed
            {
                GetComponent<Renderer>().material = leftMaterial;
            }
            else if (Input.GetKey(KeyCode.W)) // If the D key is pressed
            {
                GetComponent<Renderer>().material = rightMaterial;
            }
            else if (Input.GetKey(KeyCode.S)) // If the D key is pressed
            {
                GetComponent<Renderer>().material = leftMaterial;
            }
            else // Neither key is pressed
            {
                GetComponent<Renderer>().material = stationaryMaterial;
            }
        }
    }
}