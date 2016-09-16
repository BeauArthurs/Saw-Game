using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour {

    protected string score = File.ReadAllText("PlayerPrefs.txt"); // assigned to allow first line to be read below
    [SerializeField]private Text scoreText;
    private string[] splitrow;
    private string[] splittext;
    private List<Highscore> listofbobs = new List<Highscore>();

    void Update()
    {
        for (int i = 0; i < 1; i++)
        {
            splitrow = score.Split(',');
            for (int j = 0; j < splitrow.Length; j++)
            {
                splittext = splitrow[j].Split('.');
                Highscore bob = new Highscore();
                bob.Nick = splittext[0];
                bob.Score = int.Parse(splittext[1]);
                listofbobs.Add(bob);
            }
        }
    }

    void sortbob()
    {
    }
}
