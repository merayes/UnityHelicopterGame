using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HelicopterController : MonoBehaviour
{
    public float ascendForce = 15f; // Yükselme kuvveti
    public float descendForce = 10f; // Alçalma kuvveti
    public float rotateSpeed = 500f; // Dönüþ hýzý
    public float moveSpeed = 10f;  // Ýleri-geri hareket hýzý

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Yukarý ve aþaðý hareket
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * ascendForce, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(Vector3.down * descendForce, ForceMode.Acceleration);
        }

        // Ýleri-geri hareket
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 forwardMovement = transform.forward * moveVertical;

        // Sað-sol hareket
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;
        Vector3 lateralMovement = transform.right * moveHorizontal;

        // Dönüþ
        float rotate = Input.GetAxis("Rotate") * rotateSpeed * Time.deltaTime;
        rb.AddTorque(Vector3.up * rotate);

        // Toplam hareket
        rb.AddForce(forwardMovement + lateralMovement);
    }
}