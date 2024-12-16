using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public Player player;

    public bool isEndGame = false;
    public int score;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void EndGame()
    {
        player.GetComponent<SpriteRenderer>().enabled = false;
        isEndGame = true;
        Data_Manager.Instance.currentScore = score;
        Data_Manager.Instance.UpdateRank();

        Invoke("LoadRankScene", 2);
    }

    void LoadRankScene()
    {
        SceneManager.LoadScene(2);
    }
    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                return null;
            }
            return instance;
        }
    }
}
