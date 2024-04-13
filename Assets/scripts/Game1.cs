using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    private Animator start;
    private Animator target1;
    private Animator target2;
    private Animator target3;
    private Animator target4;
    private Animator target5;
    private string triName;
    private bool check = false;
    private void Start()
    {

    }

    private void Update()
    {
        // 현재 재생 중인 애니메이션의 정보 가져오기
        AnimatorStateInfo stateInfo = start.GetCurrentAnimatorStateInfo(0);

        // 애니메이션이 끝났는지 확인
        if (stateInfo.normalizedTime >= 1f&&check==false)
        {
            // 애니메이션이 다 끝났음을 처리
            target1.SetTrigger(triName);
            target2.SetTrigger(triName);
            target3.SetTrigger(triName);
            check = true;
            Invoke("nextAnim", 4f);
        }
    }
    private void nextAnim() 
    {
        target4.SetTrigger("On");
        target5.SetTrigger("Move");
    }
}
