using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fadeinout : MonoBehaviour
{
    float duration;
    bool startTimer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(FadeTextToFullAlpha(1f,GetComponent<Text>()));
            duration = Time.time + 2;
            startTimer = true;
        }
        if ((Time.time > duration) && (startTimer == true))
        {
            StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<Text>()));
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
