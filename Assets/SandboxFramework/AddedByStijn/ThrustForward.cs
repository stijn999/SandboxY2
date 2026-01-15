using UnityEngine;

public class ThrustForward : MonoBehaviour
{
    public float forceAmount = 500f;
    private Rigidbody rb;
    private bool isThrusting = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check for input every frame
        // Use "Jump" for the default Spacebar or specify KeyCode.Space
        if (Input.GetKey(KeyCode.Space))
        {
            isThrusting = true;
        }
        else
        {
            isThrusting = false;
        }
    }

    void FixedUpdate()
    {
        if (isThrusting)
        {
            // Apply force during the physics step
            rb.AddForce(transform.up * forceAmount);
        }
    }
}