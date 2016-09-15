using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
public class score : MonoBehaviour {

    [SerializeField]private int time; 
    [SerializeField]private Text timer;

    [SerializeField]Text FirstLettertext;
    [SerializeField]Text SecondLettertext;
    [SerializeField]Text TherdLettertext;

    [SerializeField]Image mainimage;

    [SerializeField]private Image Blockje;
    [SerializeField]private Image Blockje2;
    [SerializeField]private Image Blockje3;
    private int FirstLetter;
    private int SecondLetter;
    private int TherdLetter;
    private int CurrentLetter;
    private bool box1;
    private bool box2;
    private bool box3;

    private string filename = "PlayerPrefs.txt";


    private string[] ABC = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                             "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                             "1", "2" ,"3","4","5","6","7","8","9","0",
                             "!", "@", "#", "$", "%", "&", "*", "(", ")"};

    

	// Use this for initialization
	void Start () {
        CurrentLetter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainimage.isActiveAndEnabled == false)
        {
            time = (int)Time.time;
            timer.text = time.ToString();
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            string First = ABC[FirstLetter];
            string Second = ABC[SecondLetter];
            string Therd = ABC[TherdLetter];
            SaveScore(First+Second+Therd);
            mainimage.gameObject.SetActive(false);

        }

        if (box1 == true)
        {
            Blockje.gameObject.SetActive(true);
            Blockje2.gameObject.SetActive(false);
            Blockje3.gameObject.SetActive(false);
        }
        if (box2 == true)
        {
            Blockje.gameObject.SetActive(false);
            Blockje2.gameObject.SetActive(true);
            Blockje3.gameObject.SetActive(false);
        }
        if (box3 == true)
        {
            Blockje.gameObject.SetActive(false);
            Blockje2.gameObject.SetActive(false);
            Blockje3.gameObject.SetActive(true);
        }

        if (CurrentLetter == 1 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentLetter = 2;
            box1 = false;
            box2 = true;
            box3 = false;

        }
        else if (CurrentLetter == 2 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentLetter = 3;
            box1 = false;
            box2 = false;
            box3 = true;
        }
        else if (CurrentLetter == 3 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentLetter = 1;
            box1 = true;
            box2 = false;
            box3 = false;
        }
        else if (CurrentLetter == 1 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentLetter = 3;
            box1 = false;
            box2 = false;
            box3 = true;
        }
        else if (CurrentLetter == 2 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentLetter = 1;
            box1 = true;
            box2 = false;
            box3 = false;
        }
        else if (CurrentLetter == 3 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentLetter = 2;
            box1 = false;
            box2 = true;
            box3 = false;
        }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                UpdateText(CurrentLetter, 1);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                UpdateText(CurrentLetter, -1);
            }
    }

    void UpdateText(int letter, int Direction)
    {
        if (CurrentLetter == 1)
        {
            FirstLetter += Direction;
            if (FirstLetter < 0)
            {
                FirstLetter = ABC.Length - 1;
            }
            else if (FirstLetter == ABC.Length)
            {
                FirstLetter = 0;
            }
        }
        else if(CurrentLetter == 2)
        {
            SecondLetter += Direction;
            if (SecondLetter < 0)
            {
                SecondLetter = ABC.Length - 1;
            }
            else if (SecondLetter == ABC.Length)
            {
                SecondLetter = 0;
            }
        }
        else if (CurrentLetter == 3)
        {
            TherdLetter += Direction;
            if (TherdLetter < 0)
            {
                TherdLetter = ABC.Length - 1;
            }
            else if (TherdLetter == ABC.Length)
            {
                TherdLetter = 0;
            }
        }

        FirstLettertext.text = ABC[FirstLetter];
        SecondLettertext.text = ABC[SecondLetter];
        TherdLettertext.text = ABC[TherdLetter];

    }

    void SaveScore(string name)
    {
        if (File.Exists(filename))
        {
            FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine(name + "." + timer.text);   
            sr.Close();
        }
    }
}
