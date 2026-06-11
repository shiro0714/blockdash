using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    // 1. De static variabele die het aantal doden onthoudt over alle scenes heen
    public static int dodenTeller = 0;

    // 2. Een link naar de tekst op je scherm
    public TextMeshProUGUI deathText;

    public AudioSource deathSound;

    bool gameIsKlaar = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void winLevel()
    {
        completeLevelUI.SetActive(true);

    }

    void Start()
    {
        UpdateDeathUI();
    }
    public void Endgame()
    {
        if (gameIsKlaar == false)
        {
            gameIsKlaar = true;
            Debug.Log("Game Over");

            dodenTeller++;
            UpdateDeathUI();

            if(deathSound != null)
            {
                deathSound.Play();
            }
            Invoke("Restart", restartDelay);
        }
    }

   

    void UpdateDeathUI()
    {
        if (deathText != null)
        {
            deathText.text = "Deaths: " + dodenTeller;
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


    

