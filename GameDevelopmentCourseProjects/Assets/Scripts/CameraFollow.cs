using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] [Range(0, 1)] private float lerpSpeed = 0.125f;
    [SerializeField] private Vector3 offset = new(0, -5, 5);
    [SerializeField] private bool canLookAt = false;
    [SerializeField] private Transform target;
    Vector3 lerpPos;
    
    void LateUpdate()
    { 
        CameraMove();
    }

    void CameraMove()
    {
        if (target == null) return;

        lerpPos = Vector3.Lerp(transform.localPosition, target.localPosition - offset, lerpSpeed);
        transform.localPosition = lerpPos;

        if (canLookAt)
            transform.LookAt(target.localPosition);
    }
}