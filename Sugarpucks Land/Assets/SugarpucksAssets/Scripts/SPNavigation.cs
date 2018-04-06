using UnityEngine;
using System.Collections;

public class SPNavigation : MonoBehaviour {

    [SerializeField]
    private UnityEngine.AI.NavMeshAgent NavMeshAgent;

    private Transform NavMeshCenter;
    private float NavMeshRadius;
    public Transform Target;

    private void Awake()
    {
        NavMeshCenter = GameObject.FindGameObjectWithTag("TerrainCenter").transform;
        var radiusMarker = NavMeshCenter.GetChild(0);
        NavMeshRadius = Vector3.Distance(radiusMarker.position, NavMeshCenter.position);
    }

    private void Start()
    {
        //NavigateToRandomLocation();
    }

    private void Update()
    {

    }

    public Vector3 NavigateToRandomLocationOld()
    {
        bool success = false;
        Vector3 result = new Vector3();
        while (!success)
        {
            while (!NavMeshHelpers.RandomPointOld(NavMeshCenter.position, NavMeshRadius, NavMeshAgent.height*2, out result)) { }
            success = NavMeshAgent.SetDestination(result);
        }
        return result;
    }

    public void NavigateToRandomLocation()
    {
        bool success = false;
        Vector3 result = new Vector3();

        // loop until successfully set a destination to navigate
        while (!success)
        {
            // get a random location
            result = NavMeshHelpers.RandomPoint(NavMeshCenter.position, NavMeshRadius, NavMeshAgent.height * 2);

            // try to set the destination
            success = NavMeshAgent.SetDestination(result);
        }
    }

    public void NavigateToTarget()
    {
        NavMeshAgent.SetDestination(Target.position);
    }
}
