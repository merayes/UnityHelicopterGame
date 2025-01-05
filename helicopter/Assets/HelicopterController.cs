using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HelicopterController : MonoBehaviour
{
    public float ascendForce = 15f; // Y�kselme kuvveti
    public float descendForce = 10f; // Al�alma kuvveti
    public float rotateSpeed = 500f; // D�n�� h�z�
    public float moveSpeed = 10f;  // �leri-geri hareket h�z�

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Yukar� ve a�a�� hareket
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * ascendForce, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(Vector3.down * descendForce, ForceMode.Acceleration);
        }

        // �leri-geri hareket
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 forwardMovement = transform.forward * moveVertical;

        // Sa�-sol hareket
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;
        Vector3 lateralMovement = transform.right * moveHorizontal;

        // D�n��
        float rotate = Input.GetAxis("Rotate") * rotateSpeed * Time.deltaTime;
        rb.AddTorque(Vector3.up * rotate);

        // Toplam hareket
        rb.AddForce(forwardMovement + lateralMovement);
    }
}