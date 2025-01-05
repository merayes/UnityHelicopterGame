using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // UI'daki text objesi

    void Update()
    {
        Debug.Log("ScoreDisplay Update Çalýþýyor!");
        // Puaný güncelle
        scoreText.text = "Puan: " + RingTrigger.score;
    }
}