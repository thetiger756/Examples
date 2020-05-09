using UnityEngine;

//By Seth
//This script is responsible for applying a downward force onto the player when in the air.
public class PlayerGravity : MonoBehaviour
{
    [SerializeField]
    private float gravity = -9.81f;

    private Vector3 velocity;

    private CharacterController controller;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        velocity.y += gravity * Time.deltaTime;

        //We multiply by time twice as this more closely simulates gravity.
        controller.Move(velocity * Time.deltaTime);
    }
}
