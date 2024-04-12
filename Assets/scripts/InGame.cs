using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    private Animator animator;
    public Animator fadeOut;

    private void Start()
    {
        // 게임 오브젝트에 연결된 Animator 컴포넌트 가져오기
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // 현재 재생 중인 애니메이션의 정보 가져오기
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // 애니메이션이 끝났는지 확인
        if (stateInfo.normalizedTime >= 1f)
        {
            // 애니메이션이 다 끝났음을 처리
            fadeOut.SetTrigger("On");
            Invoke("SceneChange", 4f);
        }
    }
    private void SceneChange() 
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
    