using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
   
    public void OnTriggerEnter(Collider other)
    {
        other.transform.position =teleportPoint.position;
    }
    
}
