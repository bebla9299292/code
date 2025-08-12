using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Missile : MonoBehaviour
{
    public float speed = 3f;
    public GameObject enemy;
    public GameObject ball;
    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(enemy);
        
        Destroy(ball,3);
        
    }
}
