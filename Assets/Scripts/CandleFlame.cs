using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleFlame : MonoBehaviour
{
    public float speed = 2f; // Speed of light movement
    public float intensity = 1f; // Intensity of light flicker
    public float range = 0.0000005f; // Range of light

    private Vector3 originalPos;
    private float originalIntensity;
    private Light light;
    private Transform parentObject;

    void Start()
    {
        light = GetComponent<Light>();
        parentObject = transform.parent;

        
    }

    void Update()
    {
        Vector3 lightPos = parentObject.position;

        // Randomly move the light
        float x = Mathf.PerlinNoise(Time.time * speed, 0f) - 0.5f;
        float y = Mathf.PerlinNoise(0f, Time.time * speed) - 0.5f;
        transform.position = lightPos + new Vector3(x * 0.05f, y * 0.05f, 0);
    }


}
