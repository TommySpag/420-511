using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class GirlController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float rotspeed = 200.0f;
    Animator girlAnimation;
    private float forwardInput;
    private float sideInput;

    // Start is called before the first frame update
    void Start()
    {
        girlAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        sideInput = Input.GetAxis("Horizontal");
        if(forwardInput != 0)
        {
            girlAnimation.SetBool("idle", false);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                girlAnimation.SetBool("run", true);
                girlAnimation.SetBool("walk", false);
                transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput * 2);
            }
            else
            {
                girlAnimation.SetBool("walk", true);
                girlAnimation.SetBool("run", false);
                transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            }
        }
        else
        {
            girlAnimation.SetBool("walk", false);
            girlAnimation.SetBool("run", false);
            girlAnimation.SetBool("idle", true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            girlAnimation.SetBool("jump", true);
        }
        else
        {
            girlAnimation.SetBool("jump", false);
        }

        transform.Rotate(Vector3.up * rotspeed * Time.deltaTime * sideInput);
    }
}
