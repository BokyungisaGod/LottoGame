using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public Transform playerTransform; // �÷��̾� ������Ʈ�� Transform
    public Transform objectTransform; // ��� ������Ʈ�� Transform
    public float maxDistance = 10f; // �ִ� �Ÿ�
    public float minAlpha = 0.1f; // �ּ� ���� ��
    public float maxAlpha = 1f; // �ִ� ���� ��
    public Animator anim;
    public string portname;

    private SpriteRenderer objectRenderer; // ��� ������Ʈ�� SpriteRenderer ������Ʈ

    private void Start()
    {
        objectRenderer = GetComponent<SpriteRenderer>(); // ��� ������Ʈ�� SpriteRenderer ������Ʈ�� ������
    }

    private void Update()
    {
        // �÷��̾�� ��� ������Ʈ ������ �Ÿ� ���
        float distance = Vector3.Distance(playerTransform.position, objectTransform.position);

        // �Ÿ��� ���� ���� �� ����
        float alpha = Mathf.Lerp(maxAlpha, minAlpha, Mathf.InverseLerp(0, maxDistance, distance));

        // ���� �� ����
        objectRenderer.color = new Color(objectRenderer.color.r, objectRenderer.color.g, objectRenderer.color.b, alpha);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetTrigger("On");
        Invoke("SceneChange", 3f);
    }
    public void SceneChange()
    {
        switch (portname)
        {
            case "Jungle":
                SceneManager.LoadScene("Jungle");
                break;
            case "Sea":
                SceneManager.LoadScene("SampleScene");
                break;

        }
        
    }
}
