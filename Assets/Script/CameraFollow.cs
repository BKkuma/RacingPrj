using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // รถที่กล้องจะตาม
    public Vector3 offset = new Vector3(0, 5, -10); // ตำแหน่งกล้องจากรถ
    public float smoothSpeed = 5f; // ความเร็วในการตาม

    void LateUpdate()
    {
        if (target == null) return;

        // คำนวณตำแหน่งใหม่ของกล้อง
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // หมุนกล้องให้มองไปที่รถ
        transform.LookAt(target.position + Vector3.up * 2);
    }
}
