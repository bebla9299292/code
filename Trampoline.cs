using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int newJump = 10;
    public int oldJump = 2;
    private void OnTriggerStay(Collider other)
    {
        //ищем компоент и ставим заначение 10
       other.GetComponent<Jump>().jumpStrength = newJump;


    }
    private void OnTriggerExit(Collider other)
    {
        //ищем компоент и ставим заначение 2
        other.GetComponent<Jump>().jumpStrength = oldJump;
    }

}
