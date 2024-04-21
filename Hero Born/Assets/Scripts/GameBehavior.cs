using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public bool pause = false;
    public bool isAlive = true;

    private int _ammoCount = 20;
    public int Ammo
    {
        get { return _ammoCount; }
        set { _ammoCount = value; }
    }

    private int _playerHP = 10;
    public int HP
    {
        get { return _playerHP; }
        set { _playerHP = value; 
            if (_playerHP <= 0)
            {
                isAlive = false;
            }
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health: " + _playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "Ammo: " + _ammoCount);

        if (GUI.Button(new Rect(Screen.width - 50, 0, 50, 50), "Pause"))
        {
            if(!pause)
            {
                Time.timeScale = 0f;
                pause = true;
            }
            else
            {
                Time.timeScale = 1.0f;
                pause = false;
            }
        }

        if (!isAlive)
        {
            Time.timeScale = 0f;
            if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You died. Click to restart."))
            {
                Time.timeScale = 1.0f;
                isAlive = true;
                SceneManager.LoadScene(0);
            }
        }
    }
}