using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public Transform playerTransform; // 플레이어 오브젝트의 Transform
    public Transform objectTransform; // 대상 오브젝트의 Transform
    public float maxDistance = 10f; // 최대 거리
    public float minAlpha = 0.1f; // 최소 알파 값
    public float maxAlpha = 1f; // 최대 알파 값

    private SpriteRenderer objectRenderer; // 대상 오브젝트의 SpriteRenderer 컴포넌트

    private void Start()
    {
        objectRenderer = GetComponent<SpriteRenderer>(); // 대상 오브젝트의 SpriteRenderer 컴포넌트를 가져옴
    }

    private void Update()
    {
        // 플레이어와 대상 오브젝트 사이의 거리 계산
        float distance = Vector3.Distance(playerTransform.position, objectTransform.position);

        // 거리에 따라 알파 값 조정
        float alpha = Mathf.Lerp(maxAlpha, minAlpha, Mathf.InverseLerp(0, maxDistance, distance));

        // 알파 값 적용
        objectRenderer.color = new Color(objectRenderer.color.r, objectRenderer.color.g, objectRenderer.color.b, alpha);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
