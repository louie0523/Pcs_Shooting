using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUi : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void StarBtn()
    {
        Data_Manager.Instance.currentName = nameInput.text;
        SceneManager.LoadScene(1);
    }

    public void RankBn()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitBn()
    {
        Application.Quit();
    }
}
