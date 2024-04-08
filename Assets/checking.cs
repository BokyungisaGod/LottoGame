using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checking : MonoBehaviour
{
    void Update()
    {
        // 마우스 버튼이 클릭되었는지 확인
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스로 클릭한 위치에서 Ray를 발사
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Ray가 어떤 오브젝트와 충돌했는지 확인
            if (Physics.Raycast(ray, out hit))
            {
                // 충돌한 오브젝트의 이름을 출력
                Debug.Log("Clicked Object Name: " + hit.collider.gameObject.name);
            }
        }
    }
}
