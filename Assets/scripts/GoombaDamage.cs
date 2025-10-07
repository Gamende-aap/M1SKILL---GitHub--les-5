using UnityEngine;

public class GoombaDamage : MonoBehaviour
{


    void onCollisionEnter(Collider other)
    {

         Debug.Log("other tag" + other.tag);
        if (other.CompareTag("Player"))
        {
            // Replace this with your "lose life" code
            Debug.Log("Player hit by Goomba!");
        }
    
    }
    /*/
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Replace this with your "lose life" code
            Debug.Log("Player hit by Goomba!");
        }
    }*/
}