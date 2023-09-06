using UnityEngine;
using UnityEngine.VFX;

[RequireComponent(typeof(VisualEffect))]
public class VFXProperties : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    private VisualEffect _vfx;

    private void Awake()
    {
        _vfx = GetComponent<VisualEffect>();
    }

    private void Update()
    {
        _vfx.SetVector3("CenterPosition", cameraTransform.position);
    }
}
