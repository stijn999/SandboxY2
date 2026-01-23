using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Stabilize : MonoBehaviour
{
    public float stability = 0.5f;
    public float speed = 2.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 predictedUp = Quaternion.AngleAxis(
            rb.angularVelocity.magnitude * Mathf.Rad2Deg * stability / speed,
            rb.angularVelocity
        ) * transform.up;

        Vector3 torqueVector = Vector3.Cross(predictedUp, Vector3.up);
        rb.AddTorque(torqueVector * speed * speed);
    }
}
