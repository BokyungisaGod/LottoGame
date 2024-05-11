using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using TMPro;
public class banana1 : MonoBehaviour
{
    // 과자 프리팹
    public GameObject bananaPrefab;
    public TextMeshProUGUI text;
    public int index;

    // 던질 과자의 최소와 최대 개수
    public int maxbanana = 5;

    // 과자를 던질 최소와 최대 힘
    public float minForce = 5f;
    public float maxForce = 15f;
    public int cnt;
    private List<int> myList;
    public GameObject checkSet;

    private void Start()
    {
        myList = new List<int>();
        Invoke("Launchbanana", 4f);
    }
    void Launchbanana()
    {
        int bananaNum = Random.Range(1,20);
        myList.Add(bananaNum);
        for (int i = 0; i < bananaNum; i++) 
        {
            float bananaPos = Random.Range(-8, 9);

            // 과자 생성
            Vector2 newPos = new Vector2(bananaPos, -6f);
            GameObject banana = Instantiate(bananaPrefab, newPos, Quaternion.identity);

            // Rigidbody 컴포넌트 가져오기
            Rigidbody rb = banana.GetComponent<Rigidbody>();

            // Rigidbody가 없으면 경고 출력 후 다음으로 넘어감
            if (rb == null)
            {
                Debug.LogWarning("Rigidbody 컴포넌트를 찾을 수 없습니다: " + banana.name);
            }

            // 과자에 무작위 힘 가하기
            float force = Random.Range(minForce, maxForce);
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
        cnt++;
        if(cnt<5)
            Invoke("Launchbanana", 3f);
        else
        {
            Invoke("checkShow", 4f);
            foreach (int item in myList)
            {
                Debug.Log(item);
            }
        }
    }
    public void checkShow()
    {
        checkSet.SetActive(true);

    }
    public void checkNum()
    {
        int num = int.Parse(text.text);
        if (myList[index] == num)
        {
            Debug.Log("정답");
            if (index == 4)
                Debug.Log("승리");
        }
        else
        {
            Debug.Log("패배");

        }
        index++;

    }
}