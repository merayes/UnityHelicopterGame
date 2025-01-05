using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddColliders : MonoBehaviour
{
    void Start()
    {
        // Tüm objeleri ara
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            // Eðer objenin bir Renderer'ý varsa ve Collider'ý yoksa
            if (obj.GetComponent<Renderer>() != null && obj.GetComponent<Collider>() == null)
            {
                // Box Collider ekle
                obj.AddComponent<BoxCollider>();
            }
        }
    }
}