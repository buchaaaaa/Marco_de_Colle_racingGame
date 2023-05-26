using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pauseMenuUI;

    private bool isPause5
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f; // Stop the time
        pauseMenuUI.SetActive(true); // Show the pause menu
        Cursor.lockState = CursorLockMode.None; // Unlock the cursor
        Cursor.visible = true; // Show the cursor
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f; // Resume the time
        pauseMenuUI.SetActive(false); // Hide the pause menu
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor
        Cursor.visible = false; // Hide the cursor
    }

    public void QuitGame()
    {
        // Add any additional actions before quitting the game (e.g., save game progress)
        Application.Quit();
    }
}