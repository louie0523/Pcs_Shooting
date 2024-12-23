using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUi : MonoBehaviour
{
    public GameObject parent;
    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            NoBtn();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            YesBtn();
        }
    }
    public void YesBtn()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
    public void NoBtn()
    {
        Time.timeScale = 1.0f;
        parent.SetActive(false);
    }
}
