using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    // �߻��� ������Ʈ �迭
    public GameObject[] objectsToLaunch;

    // �߻��� ���� �ּڰ��� �ִ�
    public float minForce = 5f;
    public float maxForce = 15f;

    void FixedUpdate()
    {
        // �迭�� �ִ� �� ������Ʈ�� ����
        foreach (GameObject obj in objectsToLaunch)
        {
            // Rigidbody ������Ʈ ��������
            Rigidbody rb = obj.GetComponent<Rigidbody>();

            // Rigidbody ������Ʈ�� ���ٸ� ���� ������Ʈ�� �Ѿ
            if (rb == null)
            {
                Debug.LogWarning("Rigidbody ������Ʈ�� �����ϴ�: " + obj.name);
                continue;
            }

            // �������� ���� ũ�� ���
            float force = Random.Range(minForce, maxForce);

            // �������� �������� ���� ���ϱ�
            Vector3 launchDirection = new Vector3(Random.Range(-1f, 1f), 1f, 0f).normalized;
            rb.AddForce(launchDirection * force, ForceMode.Impulse);
        }
    }
}
