using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    AudioManager audiomanager;
    private void Start()
    {
        audiomanager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void MenuScene()
    {
        audiomanager.PlaySFX(audiomanager.click);
        SceneManager.LoadScene("Menu"); 
    }

}
