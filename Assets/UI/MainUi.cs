using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUi : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StarBtn();
        }
    }


    public void StarBtn()
    {
        SceneManager.LoadScene(0);
    }
}
