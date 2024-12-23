using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameUI : MonoBehaviour
{
    private static InGameUI instance;
    public List<Image> hpImages = new List<Image>();
    public TextMeshProUGUI scoreUI;
    public Slider BossHp;
    public GameObject PauseUI;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (BossHp.gameObject.activeSelf)
        {
            BossHp.value = (float)GameManager.Instance.Boss.Hp / GameManager.Instance.Boss.MaxHp;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            PauseUI.SetActive(true);
        }
    }
    public void EnAbleBossHpBar()
    {
        BossHp.gameObject.SetActive(true);
    }
    public void UpdateScoreUI(int score)
    {
        scoreUI.text = score.ToString("00000000");
    }
    public void UpdataPlayerHP(int hp)
    {
        for (int i = 0; i < hpImages.Count; i++)
        {
            hpImages[i].gameObject.SetActive(i < hp);
        }
    }

    public static InGameUI Instance
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
