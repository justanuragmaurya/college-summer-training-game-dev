using UnityEngine;

public class camFollow : MonoBehaviour
{
    [SerializeField] private Rigidbody targetRigidbody;
    private Vector3 initialOffset;
    private bool hasTarget;

    void Awake()
    {
        if (targetRigidbody == null)
        {
            targetRigidbody = GetComponent<Rigidbody>();
        }
        hasTarget = targetRigidbody != null;
    }

    void Start()
    {
        if (!hasTarget)
        {
            Debug.LogWarning("camFollow: No Rigidbody target assigned or found.");
            return;
        }

        initialOffset = transform.position - targetRigidbody.position;
    }

    void LateUpdate()
    {
        if (!hasTarget) return;

        transform.position = targetRigidbody.position + initialOffset;
    }
}
