using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RingTrigger : MonoBehaviour
{
    public static int score = 0; // Toplam puan

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Helikopterin Tag'i "Player" olmal�
        {
            score+=10; // Puan� art�r
            Debug.Log("Halkadan Ge�ildi! Puan: " + score);
        }
    }
}