using UnityEngine;
using System.Collections;

public class DangerZone : MonoBehaviour
{
    [SerializeField]
    private GameObject warning;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            warning.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            warning.SetActive(false);
        }
    }
}
