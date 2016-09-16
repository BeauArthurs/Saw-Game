using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]float playerSpeed = 10; //speed player moves
    [SerializeField]Image mainimage;
    [SerializeField]private Animator animator;
    private bool death = false;

    void Update()
    {
        if (death == false)
        {
            MoveForward(); // Player Movement 
        }
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
        death = true;
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        animator.SetTrigger("Death");
        mainimage.gameObject.SetActive(true);
    }

    void MoveForward()
    {

        if (Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            animator.SetBool("Front",false);
            animator.SetBool("Back", true);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            animator.SetBool("Idel", false);
        }
        if(Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            animator.SetBool("Back",false);
            animator.SetBool("Front",true);
            animator.SetBool("Back", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            animator.SetBool("Idel", false);
        }
        if(Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
            animator.SetBool("Left",true);
            animator.SetBool("Front", false);
            animator.SetBool("Back", false);
            animator.SetBool("Right", false);
            animator.SetBool("Idel", false);
        }
        if(Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            animator.SetBool("Right",true);
            animator.SetBool("Front", false);
            animator.SetBool("Back", false);
            animator.SetBool("Left", false);
            animator.SetBool("Idel", false);
        }
        if (!Input.GetKey("up") && (!Input.GetKey("right") && !Input.GetKey("left") && !Input.GetKey("down")))
        {
            animator.SetBool("Idel", true);
            animator.SetBool("Front", false);
            animator.SetBool("Back", false);
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
        }

    
    }
}