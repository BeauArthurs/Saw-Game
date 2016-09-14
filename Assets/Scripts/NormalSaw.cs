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
        speed = Random.Range(3, 5);
        body.velocity = dir;
	    
	}
    private void Update()
    {
        transform.LookAt(new Vector2( transform.position.x,transform.position.y) + body.velocity);
        Vector2 normalizedVector = body.velocity.normalized * speed;
        body.velocity = normalizedVector;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Vector2 dir = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
        body.velocity += dir;
    }


}
