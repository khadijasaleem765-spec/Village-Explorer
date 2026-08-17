using UnityEngine;

public class raycasting : MonoBehaviour
{
    public static float distanceFromTarget;
    [SerializeField] float toTarget;

        void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            toTarget = hit.distance;
            distanceFromTarget = hit.distance;
        }
    }
}
