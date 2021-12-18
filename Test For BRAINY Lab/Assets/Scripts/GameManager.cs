using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    [SerializeField] private float restartDelay = 1f;
    [SerializeField] private Transform SpawnEnemy, SpawnHero, Hero, Enemy;
    [SerializeField] private Text ScoreEnemy, ScoreHero;
    string startScoreEnemy, startScoreHero;

    private void Start()
    {
        startScoreEnemy = ScoreEnemy.text;
        startScoreHero = ScoreHero.text;

        Hero.position = SpawnHero.position;
        Enemy.position = SpawnEnemy.position;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void CheckTextChang()
    {
        if(startScoreEnemy != ScoreEnemy.text || startScoreHero != ScoreHero.text)
        {
            Hero.position = SpawnHero.position;
            Enemy.position = SpawnEnemy.position;
        }
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
