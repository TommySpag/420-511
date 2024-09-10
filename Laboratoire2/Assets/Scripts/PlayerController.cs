using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 3.0f;  // Vitesse de d�placement vers l'avant/arri�re

    private float turnSpeed = 60.0f;

    public float strafeSpeed = 5.0f;  // Vitesse de d�placement lat�ral (gauche/droite)
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        // Vous pouvez initialiser des variables ici si n�cessaire
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        {
            // Obtenir l'entr�e utilisateur
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            // D�placer l'objet vers l'avant/en arri�re en fonction de l'entr�e verticale
            transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed * forwardInput);

            // D�placer l'objet lat�ralement (gauche/droite) en fonction de l'entr�e horizontale
            // transform.Translate(Vector3.right * Time.deltaTime * strafeSpeed * horizontalInput);

            // Rotates the car based on horizontal input
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.fixedDeltaTime);
        }
    }

}
