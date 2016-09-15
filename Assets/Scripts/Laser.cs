using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
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
        Vector3 dir = new Vector3(transform.position.x + body.velocity.x, transform.position.y + body.velocity.y) - transform.position ;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        Vector2 normalizedVector = body.velocity.normalized * speed;
        body.velocity = normalizedVector;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Vector2 dir = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
        body.velocity += dir;
    }


}
