using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    void OnDestroy()
    {
        SceneManager.LoadScene("Menu");
    }
}