using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject coin;
    public GameObject Player;
    private void OnTriggerEnter(Collider Player)
    {
        Destroy(coin);
    }
}
