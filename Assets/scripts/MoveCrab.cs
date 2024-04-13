using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrab : MonoBehaviour
{
    public Animator anim;
    // 이동 속도
    public float speed = 20f; // 이동할 속도를 적절하게 조정하세요.

    // 목표 x 좌표
    public float targetX = 800f;
    // Start is called before the first frame update
    // RectTransform 컴포넌트
    private RectTransform rectTransform;
    void Start()
    {
        anim = GetComponent<Animator>();
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame

    public void Move()
    {
        anim.SetTrigger("On");
        
    }
}
    


