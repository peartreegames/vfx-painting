using System;
using UnityEngine;

namespace Painting
{
    [RequireComponent(typeof(Camera))]
    public class CopyCamera : MonoBehaviour
    {
        private Camera _cam;
        private int _mask;
        private RenderTexture _targetTexture;
        [SerializeField] private Camera target;
        

        private void Awake()
        {
            _cam = GetComponent<Camera>();
            _mask = _cam.cullingMask;
            _targetTexture = _cam.targetTexture;
        }

        private void Update()
        {
            _cam.CopyFrom(target);
            _cam.cullingMask = _mask;
            _cam.targetTexture = _targetTexture;
        }
    }
}