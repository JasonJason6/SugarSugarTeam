using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fade : MonoBehaviour {
    float duration;
    bool startTimer;
    KeyCode keyPressed;

    public Text text1;

    void Update()
    {
        Debug.Log(text1.text);
        switch (text1.text)
        {
            case "1":
                keyPressed = KeyCode.Alpha1;
                break;
            case "2":
                keyPressed = KeyCode.Alpha2;
                break;
            case "3":
                keyPressed = KeyCode.Alpha3;
                break;
            case "4":
                keyPressed = KeyCode.Alpha4;
                break;
            case "5":
                keyPressed = KeyCode.Alpha5;
                break;
            case "6":
                keyPressed = KeyCode.Alpha6;
                break;
            case "7":
                keyPressed = KeyCode.Alpha7;
                break;
            case "8":
                keyPressed = KeyCode.Alpha8;
                break;
            default:
                print("key pressed ."+text1.text+".");
                break;
        }


        if (Input.GetKeyDown(keyPressed))
        {
            StartCoroutine(FadeTextToFullAlpha(1f, text1.GetComponent<Text>()));
            duration = Time.time + 2;
            startTimer = true;
            
        }
        
        if ((Time.time > duration) && (startTimer == true))
        {
            StartCoroutine(FadeTextToZeroAlpha(1f, text1.GetComponent<Text>()));
            startTimer = false;
        }

        
    }


    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
