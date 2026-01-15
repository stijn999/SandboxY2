using UnityEngine;

public class ThrustForward : MonoBehaviour
{
    public float forceAmount = 500f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
            rb.AddForce(Vector3.up * forceAmount * Time.deltaTime);
    }
}
