using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 100;
        print("��������" + health);
        health = health + 10;
        print("��������"+health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.z += 10 * Time.deltaTime;
        transform.position = newPosition;
        print("�������:" + newPosition);

    }
}
