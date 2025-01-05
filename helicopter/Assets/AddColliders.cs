using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddColliders : MonoBehaviour
{
    void Start()
    {
        // T�m objeleri ara
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            // E�er objenin bir Renderer'� varsa ve Collider'� yoksa
            if (obj.GetComponent<Renderer>() != null && obj.GetComponent<Collider>() == null)
            {
                // Box Collider ekle
                obj.AddComponent<BoxCollider>();
            }
        }
    }
}