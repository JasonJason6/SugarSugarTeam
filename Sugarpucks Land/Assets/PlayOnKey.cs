using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnKey : MonoBehaviour {

    public AudioSource note1;
    public AudioSource note2;
    public AudioSource note3;
    public AudioSource note4;
    public AudioSource note5;
    public AudioSource note6;
    public AudioSource note7;
    public AudioSource note8;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            note1.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            note2.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            note3.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            note4.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            note5.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            note6.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            note7.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            note8.Play();
        }
    }
}
