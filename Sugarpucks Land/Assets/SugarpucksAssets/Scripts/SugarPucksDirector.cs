using UnityEngine;
using System.Collections;
using System;
using SeanStandardScript;
using UnityStandardAssets.Characters.FirstPerson;

public class SugarPucksDirector : MonoBehaviour
{
    public SugarPuck[] SugarPucks;
    public SugarPuck selectedSP;
    public SugarPuck[] refSugarPucks;
    private GameObject player;

    // Use this for initialization

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        StartCoroutine(StartSequence());
    }


    private IEnumerator StartSequence()
    {
        selectedSP = getSP();

        selectedSP.Navigation.NavigateToTarget();
        displayRefSP();
        player.GetComponent<FirstPersonController>().enabled = false;
        
        selectedSP.Note.Play();
        yield return new WaitUntil(() => !selectedSP.Note.isPlaying);
        //yield return new WaitForSeconds(3f);

        player.GetComponent<FirstPersonController>().enabled = true;

        foreach (var sugarPuck in SugarPucks)
        {
            sugarPuck.Navigation.NavigateToRandomLocation();
        }

        yield return StartCoroutine(playNotes(SugarPucks));
    }

    public SugarPuck getSP()
    {
        SugarPuck sp = SugarPucks.RandomElement();
        return sp;
    }

    private void displayRefSP()
    {
        foreach (var refSP in refSugarPucks)
        {
            if (refSP.name == selectedSP.name)
                refSP.gameObject.SetActive(true);
            else
                refSP.gameObject.SetActive(false);
        }
    }

    private IEnumerator playNotes(SugarPuck[] SugarPucks)
    {
        //waits 20 seconds then starts playing wach of the sugarpuck's notes up the scale
        yield return new WaitForSeconds(20);
        var x = 1; //can eventually be replaced with a signal the right Sugarpuck was found
        while (x == 1)
        {
            foreach (var s in SugarPucks)
            {
                yield return new WaitForSeconds(3);
                s.Note.Play();
            }

        }
    }

    private void Update()
    {
        //       AudioSource note = selectedSP.Note;
        if (Input.GetKeyDown(KeyCode.T))
        {
            selectedSP.Note.spatialBlend = 0;
            selectedSP.Note.Play();
        }
        selectedSP.Note.spatialBlend = 1;
    }


}
