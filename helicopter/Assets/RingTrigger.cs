using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RingTrigger : MonoBehaviour
{
    public static int score = 0; // Toplam puan

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Helikopterin Tag'i "Player" olmalý
        {
            score+=10; // Puaný artýr
            Debug.Log("Halkadan Geçildi! Puan: " + score);
        }
    }
}