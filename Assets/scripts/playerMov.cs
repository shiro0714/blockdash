using UnityEngine;
using UnityEngine.InputSystem;

public class playerMov : MonoBehaviour{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // fixedupdate is omdat we physics gebruiken en dat moet in een vaste tijd gebeuren
    void FixedUpdate(){
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Keyboard.current != null)
        {
            // Input voor "D" (Rechts)
            if (Keyboard.current.dKey.isPressed)
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            // Input voor "A" (Links)
            if (Keyboard.current.aKey.isPressed)
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if(rb.position.y < -1f)
            {
                FindAnyObjectByType<gameManager>().Endgame();
            }
    }
  }
}

