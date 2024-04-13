using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test01 : MonoBehaviour
{
    // Start is called before the first frame update
    public void test001 ()
    {
        Invoke("SceneChanger", 10f);
    }
    void SceneChanger() 
    {
        SceneManager.LoadScene("map");

    }
}