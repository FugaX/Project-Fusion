using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class M_Menu : MonoBehaviour {
    int level = 0;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        level++;
        SceneManager.LoadScene(level);
    }
    public void MainScene()
    {
        level = 2;
        SceneManager.LoadScene(level);
    }
    public void ControlsPage() // Method for "Controls" button 
    {
        level = 3;
        SceneManager.LoadScene(level);
    }
    public void BackControls() // Method for "Back" button on the Controls Page 
    {
        level = 2;
        SceneManager.LoadScene(level);
    }
    public void Credits() //Method used to go to the Credits Page using the "Credits" button 
    {
        level = 4;
        SceneManager.LoadScene(level);
    }
    public void Exit()
    {
        Application.Quit();
    } 
    public void StartGame()
    {
        level = 5;
        SceneManager.LoadScene(level);

    }
}
