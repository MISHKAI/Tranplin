using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tranplin : MonoBehaviour
{
    public int jumpUp = 10;

    void OnTriggerEnter(Collider other)
    {
    other.GetComponent<Jump>().jumpStrength *= jumpUp;
        
    }


    void OnTriggerExit(Collider other)
    {
    other.GetComponent<Jump>().jumpStrength /= jumpUp;
        
    }
}
