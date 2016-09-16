using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    [SerializeField]
    private Text timer;
    [SerializeField]
    private float timeTillStart;
    [SerializeField]
    private EnemySpawner gun;
    [SerializeField]
    private PlayerMovement player;
    private void Update()
    {
        timeTillStart -= Time.deltaTime;
        timer.text = Mathf.CeilToInt(timeTillStart).ToString();
        if(timeTillStart < 0)
        {
            StartGame();
        }
    }
    private void StartGame()
    {
        gun.enabled = true;
        player.enabled = true;
        this.gameObject.SetActive(false);
    }
}
