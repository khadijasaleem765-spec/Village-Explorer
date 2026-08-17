using UnityEngine;

public class openchest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float internalDistance;
    [SerializeField] bool chestOpen = false;
    [SerializeField] GameObject chest;

    void Update()
    {
internalDistance = raycasting.distanceFromTarget;
if( chestOpen == false && internalDistance < 2)
        {
            if(Input.GetKeyDown(KeyCode.E)){
            
            chestOpen = true;
            chest.GetComponent<Animator>().Play("open chest");}

        }

    }
}
