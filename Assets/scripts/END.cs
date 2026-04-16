using UnityEngine;

public class END : MonoBehaviour
{

    public gameManager manager;
    private void OnTriggerEnter(Collider other)
    {
        manager.winLevel();
    }

}
