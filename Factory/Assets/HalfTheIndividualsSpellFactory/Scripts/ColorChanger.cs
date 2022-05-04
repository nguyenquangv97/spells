using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private float timer;

    [SerializeField]
    private Material material;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 0.5f)
        {
            timer = 0;
            Color changeColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            material.color = changeColor;
        }    
    }
}
    