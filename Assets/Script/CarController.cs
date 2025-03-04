using UnityEngine;

public class CarController : MonoBehaviour
{
    public float baseSpeed = 20f;   // ความเร็วพื้นฐาน
    public float turnSpeed = 50f;   // ความเร็วในการเลี้ยว
    private float speedMultiplier = 1f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Vertical"); // กด W/S หรือ ↑/↓
        float turnInput = Input.GetAxis("Horizontal"); // กด A/D หรือ ←/→

        float moveSpeed = baseSpeed * speedMultiplier * moveInput;
        rb.velocity = transform.forward * moveSpeed;

        if (moveInput != 0) // ให้เลี้ยวได้เฉพาะตอนที่มีการขับ
        {
            transform.Rotate(Vector3.up, turnInput * turnSpeed * Time.deltaTime);
        }
    }

    public void SetSpeedMultiplier(float multiplier)
    {
        speedMultiplier = multiplier;
    }
}
