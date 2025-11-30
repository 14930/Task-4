using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
public class MeshDeformer : MonoBehaviour
{
    [Header("Deformation Physics")]
    public float springForce = 20f;
    public float damping = 5f;

    private Mesh deformingMesh;
    private Vector3[] originalVertices;
    private Vector3[] displacedVertices;

    void Start()
    {
        deformingMesh = GetComponent<MeshFilter>().mesh;
        originalVertices = deformingMesh.vertices;
        displacedVertices = new Vector3[originalVertices.Length];

        for (int i = 0; i < originalVertices.Length; i++)
        {
            displacedVertices[i] = originalVertices[i];
        }
    }

    public void AddDeformation(Vector3 worldPoint, float radius, float force)
    {
        Vector3 localPoint = transform.InverseTransformPoint(worldPoint);

        for (int i = 0; i < displacedVertices.Length; i++)
        {
            AddForceToVertex(i, localPoint, radius, force);
        }

        UpdateVertexPositions();
    }

    void AddForceToVertex(int i, Vector3 point, float radius, float force)
    {
        Vector3 pointToVertex = displacedVertices[i] - point;
        float distance = pointToVertex.magnitude;

        if (distance < radius)
        {
            float attenuation = force / (1f + pointToVertex.sqrMagnitude);
            float velocity = attenuation * Time.deltaTime;
            Vector3 velocityVector = pointToVertex.normalized * velocity;
            displacedVertices[i] += velocityVector;
        }
    }

    void UpdateVertexPositions()
    {
        deformingMesh.vertices = displacedVertices;
        deformingMesh.RecalculateNormals();
        deformingMesh.RecalculateBounds();
        GetComponent<MeshCollider>().sharedMesh = deformingMesh;
    }
}