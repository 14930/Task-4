using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables; // Namespace for XRGrabInteractable in newer versions

[RequireComponent(typeof(Rigidbody))]
public class ThrustingKnife : MonoBehaviour
{
    [Header("Thrust Settings")]
    [Tooltip("How fast the knife shoots forward when trigger is pressed.")]
    public float thrustForce = 10f;
    [Tooltip("Vibration strength when thrusting.")]
    public float activeVibration = 0.2f;

    [Header("Cutting Settings")]
    public float cutRadius = 0.05f;
    public float cutForce = -0.8f; // Negative pushes vertices IN

    [Header("References")]
    public XRGrabInteractable grabInteractable;

    private Rigidbody rb;
    private bool isThrusting = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (grabInteractable == null)
            grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        // Subscribe to the Trigger press events (Activate)
        grabInteractable.activated.AddListener(StartThrust);
        grabInteractable.deactivated.AddListener(StopThrust);
    }

    private void OnDisable()
    {
        grabInteractable.activated.RemoveListener(StartThrust);
        grabInteractable.deactivated.RemoveListener(StopThrust);
    }

    // Called when Trigger is pressed
    private void StartThrust(ActivateEventArgs args)
    {
        isThrusting = true;
    }

    // Called when Trigger is released
    private void StopThrust(DeactivateEventArgs args)
    {
        isThrusting = false;
    }

    private void FixedUpdate()
    {
        // Only apply force if we are holding it AND pressing the trigger
        if (grabInteractable.isSelected && isThrusting)
        {
            // Apply force in the LOCAL forward direction of the knife
            rb.AddForce(transform.forward * thrustForce, ForceMode.Acceleration);

            // Continuous weak vibration while motor is running
            SendHaptics(activeVibration, 0.05f);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        MeshDeformer deformer = collision.gameObject.GetComponent<MeshDeformer>();

        if (deformer != null && grabInteractable.isSelected)
        {
            // If we are thrusting, we cut deeper/easier
            float finalForce = isThrusting ? cutForce * 2f : cutForce;

            ContactPoint contact = collision.GetContact(0);
            deformer.AddDeformation(contact.point, cutRadius, finalForce);

            // Strong vibration on impact
            SendHaptics(0.8f, 0.1f);
        }
    }

    private void SendHaptics(float amplitude, float duration)
    {
        if (grabInteractable.interactorsSelecting.Count > 0)
        {
            var interactor = grabInteractable.interactorsSelecting[0] as UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor;
            if (interactor != null)
            {
                interactor.SendHapticImpulse(amplitude, duration);
            }
        }
    }
}