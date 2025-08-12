using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public int coins = 0;
    private int health = 10;
    public GameObject fireball;
    public Transform attackPoint;
   public void TakeDamage(int damage)
    {
        
        health = health- damage;
        print("Çהמנמגüו: " + health);
    }
    public void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Instantiate(fireball, attackPoint.position, attackPoint.rotation);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        CollectionCoins(other);


    }
    public void CollectionCoins(Collider other)
    {
        if (other.CompareTag("coins"))
        {
            coins++;
        }
    }
}
