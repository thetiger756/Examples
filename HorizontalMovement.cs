using UnityEngine;

//By Seth
//This script is responsible for moving the player side-to-side.
public class HorizontalMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    //I am choosing to use a CharacterController component, rather than a Rigidbody
    //because it will be much more smooth since we do not need our player to be affected by physics.
    //Think DOOM versus Marble Blast. We want DOOM.
    //
    //We need a reference to the character controller component.
    private CharacterController controller;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        HoriMovement();
    }

    private void HoriMovement()
    {
        float x = Input.GetAxis("Horizontal");

        //CharacterController.Move requires a Vector3.
        Vector3 move = transform.right * x;

        controller.Move(move * speed * Time.deltaTime);
    }
}