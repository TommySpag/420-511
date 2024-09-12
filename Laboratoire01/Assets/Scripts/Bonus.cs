using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    // Initiate variables
    private float speed = 20.0f;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        if (active)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (forwardInput > 0)
        {
            active = true;
        }
        else if (forwardInput < 0)
        {
            active = false;
        }
    }
}
