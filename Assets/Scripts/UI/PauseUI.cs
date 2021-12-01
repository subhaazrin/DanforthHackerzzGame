using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : UI 
{
    public static bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Pauses and unpauses the game if escape is pressed
        if (Input.GetKeyDown(KeyCode.Escape)){
            isPaused = !isPaused;
            if (isPaused)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }
    }

    //Overriding the method to show ui
    public override void Show()
    {
        //Activates the container
        container.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        //Time will stop when game is paused
    }
    
    

    //Overriding the method to hide ui
    public override void Hide()
    {
        //Deactivates the container
        container.SetActive(false);
        Time.timeScale = 1f;
        //Time will continue when unpaused

        isPaused = false;
        
        
    }

    //method to take user to the start menu when the button is clicked
    public void LoadMenu()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("menu");
    }

    //method quits the game *nothing happens in unity editor but should quit if the game is built and run*
    public void QuitGame()
    {
        Debug.Log("quitting");
        Application.Quit();
        
    }

}
