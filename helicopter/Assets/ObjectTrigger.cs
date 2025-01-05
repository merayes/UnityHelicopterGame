using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Helikopterin Tag'i "Player" olmal�
        {
            Debug.Log("Helikopter ge�ti!");
        }
    }
}
