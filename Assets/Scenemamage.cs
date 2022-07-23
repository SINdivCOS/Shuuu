using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemamage : MonoBehaviour
{
    
    public void OpenGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void OpenMenu()
    {
        
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Pause()
    {
        
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
