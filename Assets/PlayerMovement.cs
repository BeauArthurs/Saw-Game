using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]float playerSpeed = 10; //speed player moves

    void Update()
    {
        MoveForward(); // Player Movement 
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == GameObject.FindGameObjectWithTag("Death"))
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(this.gameObject);
        //start endscreen
    }

    void MoveForward()
    {

        if (Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }
    }
}