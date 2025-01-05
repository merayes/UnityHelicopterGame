using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PropellerRotation : MonoBehaviour
{
    public float rotationSpeed = 1000f;

    void Update()
    {
        // G�rsel d�n�� (fiziksel etkisiz)
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}