using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // R�f�rence � l'objet du joueur
    public Vector3 offset;    // D�calage de la cam�ra par rapport au joueur

    void Start()
    {
        // Si le d�calage n'est pas d�fini, le calculer par rapport � la position actuelle de la cam�ra
        if (offset == Vector3.zero)
        {
            offset = transform.position - player.position;
        }
    }

    void LateUpdate()
    {
        // Positionner la cam�ra derri�re le joueur en tenant compte de la rotation du joueur
        Vector3 desiredPosition = player.position + player.rotation * offset;
        transform.position = desiredPosition;

        // Faire en sorte que la cam�ra regarde toujours le joueur (ou un point devant le joueur)
        transform.LookAt(player.position + player.forward * 10f);
    }
}
