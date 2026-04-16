using UnityEngine;

public class playerColision : MonoBehaviour
{
    public playerMov movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstakel")
        {
            movement.enabled = false;
            FindAnyObjectByType <gameManager>().Endgame();

        }
    }
}
