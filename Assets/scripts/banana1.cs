using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana1 : MonoBehaviour
{
    // 과자 프리팹
    public GameObject bananaPrefab;

    // 던질 과자의 최소와 최대 개수
    public int minbanana = 1;
    public int maxbanana = 5;

    // 과자를 던질 최소와 최대 힘
    public float minForce = 5f;
    public float maxForce = 15f;

    void Start()
    {
        // 과자 던지기
        Launchbanana();
    }

    void Launchbanana()
    {
        // 과자 개수 무작위로 선택
        int numbanana = Random.Range(minbanana, maxbanana + 1);

        for (int i = 0; i < numbanana; i++)
        {
            // 과자 생성
            GameObject banana = Instantiate(bananaPrefab, transform.position, Quaternion.identity);

            // Rigidbody 컴포넌트 가져오기
            Rigidbody rb = banana.GetComponent<Rigidbody>();

            // Rigidbody가 없으면 경고 출력 후 다음으로 넘어감
            if (rb == null)
            {
                Debug.LogWarning("Rigidbody 컴포넌트를 찾을 수 없습니다: " + banana.name);
                continue;
            }

            // 과자에 무작위 힘 가하기
            float force = Random.Range(minForce, maxForce);
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}