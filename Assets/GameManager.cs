using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



    public void QuitGame()
    {
        Application.Quit();

    }







}

