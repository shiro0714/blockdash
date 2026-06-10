using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // 'static' zorgt ervoor dat dit getal onthouden wordt bij het wisselen van scenes.
    // We zetten hem standaard op 1 (je eerste level).
    public static int laatsteSceneIndex = 1;

    public void startGame()
    {
        Debug.Log("start");
        // Start altijd bij het eerste level (index 1)
        SceneManager.LoadScene(1);
    }

    // VOEG DIT TOE: Een methode voor een 'Hervat' of 'Verdergaan' knop
    public void HervatSpel()
    {
        Debug.Log("Hervat vanaf level: " + laatsteSceneIndex);
        SceneManager.LoadScene(laatsteSceneIndex);
    }
}
