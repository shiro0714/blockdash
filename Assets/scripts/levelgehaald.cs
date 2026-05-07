using UnityEngine;
using UnityEngine.SceneManagement;
public class levelgehaald : MonoBehaviour{
    public void LaadNieuweLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}