using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class M_Menu : MonoBehaviour {
    int level = 0;
    
    void Start()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //Exit if Esc key pressed
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //Exit if Esc key pressed
            Application.Quit();
        }
    }
    public void ChangeScene()
    {
        level++;
        SceneManager.LoadScene(level);
    }
}
