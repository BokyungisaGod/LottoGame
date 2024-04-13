using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAnana : MonoBehaviour
{
    // Start is called before the first frame update
    // 발사할 오브젝트 배열
    public GameObject[] objectsToLaunch;

    // 발사할 힘의 최솟값과 최댓값
    public float minForce = 5f;
    public float maxForce = 15f;

    void FixedUpdate()
    {
        // 배열에 있는 각 오브젝트에 대해
        foreach (GameObject obj in objectsToLaunch)
        {
            // Rigidbody 컴포넌트 가져오기
            Rigidbody rb = obj.GetComponent<Rigidbody>();

            // Rigidbody 컴포넌트가 없다면 다음 오브젝트로 넘어감
            if (rb == null)
            {
                Debug.LogWarning("Rigidbody 컴포넌트가 없습니다: " + obj.name);
                continue;
            }

            // 무작위한 힘의 크기 계산
            float force = Random.Range(minForce, maxForce);

            // 무작위한 방향으로 힘을 가하기
            rb.AddForce(Vector2.up * force, ForceMode.Impulse);
        }
    }
}
