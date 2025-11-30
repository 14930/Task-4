using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

[RequireComponent(typeof(Rigidbody))]
public class VRKnife : MonoBehaviour
{
    [Header("Cutting Settings")]
    public float cutRadius = 0.1f;
    public float cutForce = -0.5f;

    [Header("Haptics")]
    [Tooltip("Reference to the Grab Interactable on this object.")]
    public XRGrabInteractable grabInteractable;
    public float hapticIntensity = 0.5f;
    public float hapticDuration = 0.1f;

    private void OnValidate()
    {
        if (grabInteractable == null)
        {
            grabInteractable = GetComponent<XRGrabInteractable>();
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        MeshDeformer deformer = collision.gameObject.GetComponent<MeshDeformer>();

        if (deformer != null)
        {
            ContactPoint contact = collision.GetContact(0);
            deformer.AddDeformation(contact.point, cutRadius, cutForce);
            TriggerHaptic();
        }
    }

    private void TriggerHaptic()
    {
        if (grabInteractable != null && grabInteractable.isSelected)
        {
            var interactor = grabInteractable.interactorsSelecting[0];

            if (interactor is XRBaseInputInteractor inputInteractor)
            {
                inputInteractor.SendHapticImpulse(hapticIntensity, hapticDuration);
            }
        }
    }
}