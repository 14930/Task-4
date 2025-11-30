using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables; // Use this namespace for Unity 6 / XR Toolkit 3.x
// If using older XR Toolkit, remove the .Interactables line above.

[RequireComponent(typeof(Rigidbody))]
public class PowerKnife : MonoBehaviour
{
    [Header("Cutting Stats")]
    public float cutRadius = 0.05f;
    public float cutForce = -1.5f; // Negative to push vertices in

    [Header("Thrust Mechanics")]
    [Tooltip("Force applied forward when Trigger is pressed.")]
    public float thrustForce = 15f;
    public float vibrationStrength = 0.3f;

    [Header("Setup")]
    public XRGrabInteractable grabInteractable;

    private Rigidbody rb;
    private bool isThrusting = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (grabInteractable == null) grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        // Hook into Unity VR Template events
        grabInteractable.activated.AddListener(StartThrust);
        grabInteractable.deactivated.AddListener(StopThrust);
    }

    private void OnDisable()
    {
        grabInteractable.activated.RemoveListener(StartThrust);
        grabInteractable.deactivated.RemoveListener(StopThrust);
    }

    private void StartThrust(ActivateEventArgs args) { isThrusting = true; }
    private void StopThrust(DeactivateEventArgs args) { isThrusting = false; }

    private void FixedUpdate()
    {
        // Only thrust if holding the knife AND pressing trigger
        if (grabInteractable.isSelected && isThrusting)
        {
            // Propel knife forward (Local Z axis)
            rb.AddForce(transform.forward * thrustForce, ForceMode.Acceleration);

            // Continuous vibration while motor is running
            SendHaptic(vibrationStrength, 0.05f);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        // Check if we hit the body
        FleshDeformer flesh = collision.gameObject.GetComponent<FleshDeformer>();

        if (flesh != null && grabInteractable.isSelected)
        {
            // If thrusting, cut stronger
            float currentForce = isThrusting ? cutForce * 2.0f : cutForce;

            ContactPoint contact = collision.GetContact(0);
            flesh.ApplyCut(contact.point, cutRadius, currentForce);

            // Impact vibration
            SendHaptic(0.5f, 0.1f);
        }
    }

    private void SendHaptic(float amp, float dur)
    {
        if (grabInteractable.interactorsSelecting.Count > 0)
        {
            // Send haptics to the hand holding the knife
            var interactor = grabInteractable.interactorsSelecting[0] as UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor;
            if (interactor != null) interactor.SendHapticImpulse(amp, dur);
        }
    }
}