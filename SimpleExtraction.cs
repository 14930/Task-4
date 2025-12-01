using UnityEngine;

public class SimpleExtraction : MonoBehaviour
{
    private Vector3 initialPosition;
    public float pullDistanceNeeded = 0.005f;
    private bool isExtracted = false;
    private Rigidbody rb;
    private Vector3 lastPosition;
    private float velocityThreshold = 0.1f;

    void Start()
    {
        initialPosition = transform.position;
        lastPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }

    void Update()
    {
        if (isExtracted || rb == null) return;

        // احسب المسافة من المكان الأصلي
        float distance = Vector3.Distance(transform.position, initialPosition);
        
        // احسب السرعة
        float velocity = Vector3.Distance(transform.position, lastPosition) / Time.deltaTime;
        lastPosition = transform.position;

        Debug.Log($"Distance: {distance}, Velocity: {velocity}");

        // إذا اتحرك السن بسرعة كافية أو مسافة كافية = تخلع
        if (distance >= pullDistanceNeeded || velocity > velocityThreshold)
        {
            ExtractTooth();
        }
    }

    void ExtractTooth()
    {
        isExtracted = true;
        transform.SetParent(null);
        rb.isKinematic = false;
        rb.useGravity = true;
        Debug.Log("Tooth Extracted!");
    }
}