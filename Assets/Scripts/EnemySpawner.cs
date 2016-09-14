using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    [SerializeField]private GameObject NormalEnemy;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(spawnbullet());
    }


    IEnumerator spawnbullet()
    {
        for (int i = 1; i > 0; i++)
        {
            GameObject.Instantiate(NormalEnemy, new Vector3(0, -1, 0), transform.rotation);
            yield return new WaitForSeconds(10);
        }
    }
}
