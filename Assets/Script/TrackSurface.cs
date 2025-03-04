using UnityEngine;

public class TrackSurface : MonoBehaviour
{
    public float speedMultiplier = 1.0f; // ค่าเพิ่มหรือลดความเร็ว

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ตรวจจับเฉพาะรถของผู้เล่น
        {
            CarController car = other.GetComponent<CarController>();
            if (car != null)
            {
                car.SetSpeedMultiplier(speedMultiplier);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CarController car = other.GetComponent<CarController>();
            if (car != null)
            {
                car.SetSpeedMultiplier(1.0f); // กลับสู่ความเร็วปกติ
            }
        }
    }
}
