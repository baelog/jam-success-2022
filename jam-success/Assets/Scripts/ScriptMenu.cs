using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void quitButton() {
        Debug.Log("exitgame");  
        Application.Quit();  
    }

    public void playButton() {
        SceneManager.LoadScene("Map");
    }
}
