using UnityEngine;

public class TrackSurface : MonoBehaviour
{
    public float speedMultiplier = 1.0f; // �����������Ŵ��������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��Ǩ�Ѻ੾��ö�ͧ������
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
                car.SetSpeedMultiplier(1.0f); // ��Ѻ���������ǻ���
            }
        }
    }
}
