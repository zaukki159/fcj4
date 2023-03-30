using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public int airShipsDestroyed;
    public static int hiScore;
    public TextMeshProUGUI hiScoreText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI levelText;
    [Header("Guns")]
    public GameObject[] guns;
    [Header("Upgrades")]
    public int firstupgrade = 100;
    public int ndupgrade = 200;
    public int rdupgrade = 300;
    [Header("Waves")]
    public GameObject[] waves;
    public int secondWave = 3;
    public int thirdWave = 7;
    public int fourthWave = 12;
    public int fifthWave = 22;
    public int sixthWave = 23;
    public int seventhWave = 24;
    public int eightWave = 25;
    public int ninthWave = 26;
    public int tenthWave = 27;


    private void Start()
    {
        guns[0].SetActive(true);
        guns[1].SetActive(false);
        guns[2].SetActive(false);
        guns[3].SetActive(false);
        levelText.text = 1.ToString();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
    }


    public void QuitGame()
    {
        Application.Quit();

    }

    private void Update()
    {
        if(airShipsDestroyed >= firstupgrade && airShipsDestroyed < ndupgrade)
        {
            guns[0].SetActive(false);
            guns[1].SetActive(true);
            guns[2].SetActive(false);
            guns[3].SetActive(false);
            levelText.text = 2.ToString();

        }

        else if(airShipsDestroyed >= ndupgrade && airShipsDestroyed < rdupgrade)
        {
            guns[0].SetActive(false);
            guns[1].SetActive(false);
            guns[2].SetActive(true);
            guns[3].SetActive(false);
            levelText.text = 3.ToString();
        }

        else if (airShipsDestroyed >= rdupgrade)
        {
            guns[0].SetActive(false);
            guns[1].SetActive(false);
            guns[2].SetActive(false);
            guns[3].SetActive(true);
            levelText.text = 4.ToString();
        }

        if (airShipsDestroyed >= secondWave)
        {
            waves[0].SetActive(true);
        }

        if (airShipsDestroyed >= thirdWave)
        {
            waves[1].SetActive(true);
        }
        if (airShipsDestroyed >= fourthWave)
        {
            waves[2].SetActive(true);
        }
        if (airShipsDestroyed >= fifthWave)
        {
            waves[3].SetActive(true);
        }
        if (airShipsDestroyed >= sixthWave)
        {
            waves[4].SetActive(true);
        }
        if (airShipsDestroyed >= seventhWave)
        {
            waves[5].SetActive(true);
        }
        if (airShipsDestroyed >= eightWave)
        {
            waves[6].SetActive(true);
        }
        if (airShipsDestroyed >= ninthWave)
        {
            waves[7].SetActive(true);
        }
        if (airShipsDestroyed >= tenthWave)
        {
            waves[8].SetActive(true);
        }
    }
    public void FixedUpdate()
    {
        scoreText.text = score.ToString();
        if(score > hiScore)
        {
            hiScore = score;
            hiScoreText.text = hiScore.ToString();
        }
    }








}

