using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterStabilizer : MonoBehaviour
{
    public float stabilizationStrength = 2f; // Stabilizasyon g�c�
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Yan hareketleri s�f�rlama
        Vector3 angularVelocity = rb.angularVelocity;
        angularVelocity.x = Mathf.Lerp(angularVelocity.x, 0, stabilizationStrength * Time.deltaTime);
        angularVelocity.z = Mathf.Lerp(angularVelocity.z, 0, stabilizationStrength * Time.deltaTime);
        rb.angularVelocity = angularVelocity;
    }
}