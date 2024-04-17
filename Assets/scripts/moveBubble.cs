using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBubble : MonoBehaviour
{
    Rigidbody2D rigid;
    float speed = 2f;
    Vector2 moveDirection; // 초기 이동 방향
    AudioManager audiomanager;

    void Start()
    {
        audiomanager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        rigid = GetComponent<Rigidbody2D>();

        // 랜덤한 초기 이동 방향 설정
        float randomAngle = Random.Range(0f, 360f);
        moveDirection = Quaternion.Euler(0, 0, randomAngle) * Vector2.up;
    }

    // Update is called once per frame
    void Update()
    {
        // 비눗방울의 이동
        rigid.velocity = moveDirection * speed;
    }

    // 충돌 이벤트
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audiomanager.PlaySFX(audiomanager.Bubble);
        // 충돌된 두 비눗방울의 위치 차이를 계산하여 방향 벡터로 사용
        Vector2 direction = (collision.transform.position - transform.position).normalized;
        moveDirection = -direction; // 반대 방향으로 설정
    }
}
