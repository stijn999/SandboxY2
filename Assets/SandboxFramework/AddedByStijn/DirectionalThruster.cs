using UnityEngine;

[RequireComponent(typeof(SwitchListener))]
public class DirectionalThruster : MonoBehaviour
{
    [Header("Thruster Settings")]
    [Tooltip("The magnitude of the thrust force to apply.")]
    public float thrustForce = 1000f;

    [Tooltip("The Rigidbody to apply the force to. If null, the script will look for a Rigidbody on this object or a parent.")]
    public Rigidbody targetRigidbody;

    [Tooltip("If true, the thruster will apply a continuous force only during FixedUpdate.")]
    public bool isThrusting = false;

    private Rigidbody rb;

    void Start()
    {
        // Use the explicitly set Rigidbody if provided
        if (targetRigidbody != null)
        {
            rb = targetRigidbody;
        }
        else
        {
            // Try to find a Rigidbody on this object or its parents
            rb = GetComponentInParent<Rigidbody>();
        }

        if (rb == null)
        {
            Debug.LogError("DirectionalThruster on " + gameObject.name + " requires a Rigidbody component on itself or a parent.");
            enabled = false; // Disable the script if no Rigidbody is found
        }
    }

    void FixedUpdate()
    {
        // Only apply force if the thruster is active and we have a Rigidbody
        if (isThrusting && rb != null)
        {
            // Get the local forward direction of the thruster component
            Vector3 thrustDirection = transform.forward;

            // Apply the force in the forward direction. Use ForceMode.Force for continuous acceleration.
            rb.AddForce(thrustDirection * thrustForce, ForceMode.Force);
        }
    }

    public void ActivateThruster()
    {
        isThrusting = true;
    }

    public void DeactivateThruster()
    {
        isThrusting = false;
    }
}