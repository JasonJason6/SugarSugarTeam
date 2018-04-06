using UnityEngine;
using System.Collections;

public class TestNavigate : MonoBehaviour {

    [SerializeField]
    private UnityEngine.AI.NavMeshAgent NavMeshAgent;
    [SerializeField]
    private Transform TargetLocation;
    
	// Update is called once per frame
	void Update ()
	{
	    NavMeshAgent.destination = TargetLocation.position;
	}
}
