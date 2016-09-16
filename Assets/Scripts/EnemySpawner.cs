using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    [SerializeField]private GameObject NormalEnemy;
    [SerializeField]
    private Sprite offSkin;
    [SerializeField]
    private Sprite OnSkin;
    [SerializeField]
    private Sprite fireSkin;
    [SerializeField]
    private SpriteRenderer Srenderer;
    private float timer;
    private void Start()
    {
        timer = 10;
    }
    void Update()
    {
        timer -= Time.deltaTime;
       // Debug.Log(timer);
        if (timer > 2)
        {
            Debug.Log("Stage 1");
            Srenderer.sprite = offSkin;
        }
        else if (timer > 1)
        {
            Debug.Log("Stage 2");
            Srenderer.sprite = OnSkin;
        }
        else if (timer > 0)
        {
            Debug.Log("Stage 3");
            Srenderer.sprite = OnSkin;
        }
        else if (timer < 0)
        {
            Debug.Log("Stage 4");
            Instantiate(NormalEnemy,transform.position,transform.rotation);
            timer = 10;
        }
    }
}
