using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    bool gameIsKlaar = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void winLevel() { 
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
}
