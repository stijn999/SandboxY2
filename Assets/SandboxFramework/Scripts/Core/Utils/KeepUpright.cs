using StarterAssets;
using UnityEngine;

[DisallowMultipleComponent]
public class KeepUpright : MonoBehaviour
{
    void LateUpdate()
    {
        if (transform.parent && transform.parent.parent == null)
        {
            transform.rotation = transform.rotation * Quaternion.FromToRotation(transform.up, Vector3.up);
        }
    }
}
