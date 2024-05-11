using UnityEngine;
using TMPro;

public class numController : MonoBehaviour
{
    public TextMeshProUGUI num;
    private int cnt;
    private bool canInput = true; // 입력을 받을 수 있는 상태인지 나타내는 플래그
    public float inputCooldownTime = 0.05f; // 입력 처리 후 다음 입력까지의 시간 간격

    private void Update()
    {
        if (canInput)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("g");
                plusNum();
                canInput = false;
                Invoke("EnableInput", inputCooldownTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                minusNum();
                canInput = false;
                Invoke("EnableInput", inputCooldownTime);
            }
        }
    }

    // 입력 후 일정 시간 동안 입력을 무시하는 함수
    private void EnableInput()
    {
        canInput = true;
    }

    public void plusNum()
    {
        cnt = int.Parse(num.text) < 20 ? int.Parse(num.text) + 1 : 20;
        num.text = cnt.ToString();
    }

    public void minusNum()
    {
        cnt = int.Parse(num.text) > 1 ? int.Parse(num.text) - 1 : 1;
        num.text = cnt.ToString();
    }
    
}
