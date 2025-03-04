using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // ö�����ͧ�е��
    public Vector3 offset = new Vector3(0, 5, -10); // ���˹觡��ͧ�ҡö
    public float smoothSpeed = 5f; // ��������㹡�õ��

    void LateUpdate()
    {
        if (target == null) return;

        // �ӹǳ���˹�����ͧ���ͧ
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // ��ع���ͧ����ͧ价��ö
        transform.LookAt(target.position + Vector3.up * 2);
    }
}
