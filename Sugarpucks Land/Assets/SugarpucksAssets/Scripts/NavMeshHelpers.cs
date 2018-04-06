using UnityEngine;
using System.Collections;

public static class NavMeshHelpers
{
    private static int maxRandomPointAtempts = 30;

    public static bool RandomPointOld( Vector3 center, float range, float samplePosMaxDist, out Vector3 result, int navMeshMask = UnityEngine.AI.NavMesh.AllAreas)
    {
        for (int i = 0; i < maxRandomPointAtempts; i++)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            UnityEngine.AI.NavMeshHit hit;
            if (UnityEngine.AI.NavMesh.SamplePosition(randomPoint, out hit, samplePosMaxDist, navMeshMask))
            {
                result = hit.position;
                return true;
            }
        }
        result = Vector3.zero;
        return false;
    }

    public static Vector3 RandomPoint(Vector3 center, float range, float samplePosMaxDist, int navMeshMask = UnityEngine.AI.NavMesh.AllAreas)
    {
        // choose a random point and sample it. 
        // if it's ok then return the position, if not then repeat the process 
        while (true)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            UnityEngine.AI.NavMeshHit hit;
            if (UnityEngine.AI.NavMesh.SamplePosition(randomPoint, out hit, samplePosMaxDist, navMeshMask))
            {
                return hit.position;
            }
        }
    }
}