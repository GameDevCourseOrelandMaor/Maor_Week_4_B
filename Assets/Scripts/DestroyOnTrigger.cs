using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a collider with the given tag,
 * and it blocks the car from leaving the sides of the road
 */
public class DestroyOnTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [Tooltip("For recognizing the left or right wall")]
    [SerializeField] string triggeringWall;
   
    [Tooltip("For defining how hard the car would be knocked back from the walls")]
    [SerializeField] int knochback;
    PlayerMovement playerMovement;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Debug.Log("GAME OVER!");
        }
        if (other.tag == triggeringWall  && enabled)
        {
            this.transform.position -= new Vector3(knochback * playerMovement.getHorizontal(), 0, 0) * playerMovement.getSpeed() * Time.deltaTime;
        }
       
    }

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
