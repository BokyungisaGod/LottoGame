using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class countdown : MonoBehaviour
{
    public Text countdownText;
    public Image backgroundImage; // 텍스트와 함께 사라질 배경 이미지

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        int count = 3;

        // 3, 2, 1 카운트다운 표시
        while (count > 0)
        {
            countdownText.text = count.ToString();
            yield return new WaitForSeconds(1f);
            count--;
        }

        countdownText.text = "Start!";

        // 원하는 대기 시간 설정
        yield return new WaitForSeconds(1f);


        // 카운트다운 UI 및 배경 이미지 숨기거나 비활성화
        countdownText.gameObject.SetActive(false);
        backgroundImage.gameObject.SetActive(false);
    }

}
