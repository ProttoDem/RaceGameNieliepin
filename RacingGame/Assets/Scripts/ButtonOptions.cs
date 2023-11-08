using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonOptions : MonoBehaviour
{
    public GameObject NicknameInput;
    public void ConfirmNickname()
    {
        UIManager.PlayerNickname = NicknameInput.GetComponent<Text>().text;
    }

    public void Track1()
    {
        SceneManager.LoadScene(1);

    }

    public void Track2()
    {
        SceneManager.LoadScene(2);
    }

    public void Shop()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    /*
        public void Start()
        {
            NicknameInput.GetComponent<Text>().text = UIManager.PlayerNickname; 
        }*/
}
