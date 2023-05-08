using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAgain : MonoBehaviour
{
    [SerializeField] private GameObject renderLast;
    private void OnTriggerExit(Collider col)
    {
        
        if(col.tag == "Player")
        {
            renderLast.SetActive(false);
        }
    }
}
