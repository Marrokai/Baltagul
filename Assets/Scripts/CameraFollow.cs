using UnityEngine;

public class CameraFollow : MonoBehaviour {
    //Target player object
    public Transform target;
    //Smoothness setting
    public float smoothSpeed = 12.5f;
    //Camera offset so that it's 3rd person
    public Vector3 offset;
    //Camera temp location
    Vector3 desiredPos;
    //Camera pos interpolated so that it smoothly goes to object
    Vector3 smoothedPos;
    private void FixedUpdate()
    {
        desiredPos = target.position + offset;
        smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPos;
        transform.LookAt(target);
    }
}
