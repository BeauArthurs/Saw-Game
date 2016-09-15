using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Fade : MonoBehaviour {
    [SerializeField]
    private Image fade;
    private bool end;
    private GameObject On;
    private GameObject Off;
	private void OnEnable()
    {
        Color newColor = fade.color;
        newColor.a = 0;
        fade.color = newColor;
        end = false;
        StartCoroutine(FadeTo(1.0f, 1.0f));
    }
    public void SetON(GameObject screenOn)
    {
        On = screenOn;
    }
    public void SetOff(GameObject screenOff)
    {
        Off = screenOff;
    }
    IEnumerator FadeTo(float aValue, float aTime)
    {
        float alpha = fade.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(0, 0, 0, Mathf.Lerp(alpha, aValue, t));
            fade.color = newColor;
            yield return null;
        }
        if(!end)
        {
            end = true;
            On.SetActive(true);
            Off.SetActive(false);
            StartCoroutine(FadeTo(0f, 1.0f));
            
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
