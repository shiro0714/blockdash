using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    bool gameIsKlaar = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void winLevel()
    {
        completeLevelUI.SetActive(true);

    }
    public void Endgame()
    {
        if (gameIsKlaar == false)
        {
            gameIsKlaar = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    void Update()
    {
        // Tip: .wasPressedThisFrame is beter dan .isPressed, 
        // omdat hij dan maar één keer reageert per klik.
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            // 1. Sla de index van het HUIDIGE level op in het menu-script
            menu.laatsteSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // 2. Ga daarna pas naar het menu (index 0)
            SceneManager.LoadScene(0);
        }
    }
}


    

