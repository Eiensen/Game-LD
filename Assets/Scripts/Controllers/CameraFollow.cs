using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 Offset;
    public float Velocity;
    public float MinDistance;

   
    void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        var targetPos = target.transform.position + Offset;

        if (Vector3.Distance(transform.position, targetPos) < MinDistance)
        {
            return;
        }
        var newPos = Vector3.Lerp(transform.position, targetPos, Velocity * Time.fixedDeltaTime);
        transform.Translate(transform.InverseTransformPoint(newPos));
    }
}
