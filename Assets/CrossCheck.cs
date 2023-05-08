using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossCheck : MonoBehaviour
{
    [SerializeField] private GameObject renderLast;
    private void Start()
    {
        renderLast.SetActive(false);
    }
    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "Player")
        {
            renderLast.SetActive(true);
        }    
    }
}
