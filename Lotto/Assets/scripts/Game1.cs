using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    public Animator start;
    public Animator target1;
    public Animator target2;
    public Animator target3;
    public Animator target4;
    public Animator target5;
    public string triName;
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
