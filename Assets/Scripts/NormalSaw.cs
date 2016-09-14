using UnityEngine;
using System.Collections;

public class NormalSaw : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D body;
    [SerializeField]
    private int speed;
	void Start ()
    {
        Vector2 dir = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        speed = Random.Range(0, 5);
        body.velocity = dir;
	    
	}
    //time test
    private void Update()
    {
        transform.LookAt(new Vector2( transform.position.x,transform.position.y) + body.velocity);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = .5f;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
    }
    
    //end Test


}
