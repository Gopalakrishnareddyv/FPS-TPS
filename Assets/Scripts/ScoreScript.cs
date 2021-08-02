using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    int coins;
    int enemies;
    public Text coinsText;
    public Text enemiesText;
    public static ScoreScript scoreInstance;
    private void Awake()
    {
        scoreInstance = this;
    }
    public void CoinIncrement()
    {
        coins++;
        coinsText.text = "Coins : " + coins;
    }
    public void EnemyIncrement()
    {
        enemies++;
        enemiesText.text = "Enemies : " + enemies;
        if (enemies == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
