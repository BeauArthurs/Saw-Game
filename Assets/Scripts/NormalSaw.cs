using UnityEngine;
using System.Collections;

public class NormalSaw : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D body;
	void Start ()
    {
        Vector2 dir = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        body.velocity = dir;
	
	}
    //time test
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Time.timeScale -= .1f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Time.timeScale += .1f;
        }
    }
    //end Test


}
