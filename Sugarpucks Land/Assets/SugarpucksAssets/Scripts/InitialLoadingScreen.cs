using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InitialLoadingScreen : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(Load());
	}

    private IEnumerator Load()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadSceneAsync(2);
    }
	
}
