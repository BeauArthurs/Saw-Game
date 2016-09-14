using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class score : MonoBehaviour {

    [SerializeField]private int time; 
    [SerializeField]private Text timer; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time = (int)Time.time;
        timer.text = time.ToString();
        
	}
}
