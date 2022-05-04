using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornetMotion : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float Speed = 5.0f;
    [SerializeField] private float Life = 10.00f;
    private float currentLife = 0.0f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 2.0f;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        if (currentLife >= Life)
        {
            Destroy(gameObject);
        }
        else
        {
            currentLife += Time.deltaTime;
        }
    }
}
