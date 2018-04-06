using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SPCollisionControl : MonoBehaviour {

    public SugarPuck currSP;
    public AudioClip incorrectSound;
    public AudioClip correctSound;

    void Update() {
        if (currSP == null) {
        GameObject director = GameObject.Find("SPDirector");
        SugarPucksDirector SPDirect = director.GetComponent<SugarPucksDirector>();
        currSP = SPDirect.selectedSP;
        }
    }
    void OnCollisionEnter(Collision col)  //Plays Sound Whenever collision detected
    {
        if (col.gameObject.tag == "SugarPuck")
        {
            if (col.gameObject.name == currSP.name)
            {
                //AudioSource.PlayClipAtPoint(correctSound, col.transform.position);
                //GameObject source = GameObject.Find("One shot audio");
                SceneManager.LoadSceneAsync(3);
            }
            else
            {
                AudioSource.PlayClipAtPoint(incorrectSound, col.transform.position);
                GameObject source = GameObject.Find("One shot audio");
            }
            
        }
    }

}
