using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporterScript : MonoBehaviour
{
    public Transform player;
    public Transform recieve;
    
    private bool playerTouch = false;


    public void Update()
    {
        if(playerTouch)
        {
            Vector3 portalPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalPlayer);
            if(dotProduct < 0f)
            { 
                float rotationDiff = -Quaternion.Angle(transform.rotation, recieve.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);
                
                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalPlayer;
                
                Debug.Log("teleport");

                player.position = recieve.position + positionOffset;
                playerTouch = false;
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            playerTouch = true;
        }

    }

    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "Player")
        {
            playerTouch = false;
        }
    }
}
