using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]float playerSpeed = 10; //speed player moves
    [SerializeField]Image mainimage;

    void Update()
    {
        MoveForward(); // Player Movement 
        BulletSlow();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == GameObject.FindGameObjectWithTag("Death"))
        {
            Death();
        }
    }
    void BulletSlow()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = .5f;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
    }
    void Death()
    {
        Destroy(this.gameObject);
        mainimage.gameObject.SetActive(true);
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