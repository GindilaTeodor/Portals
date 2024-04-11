using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{

    float time = 5;
    private GameObject portal2; // Reference to the second portal

    void Start()
    {
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag== "Portal1" && time>5)
        {
            // Update the reference to Portal2
            portal2 = GameObject.FindGameObjectWithTag("Portal2");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            else
            {
                Debug.LogWarning("Portal2 not found.");
            }
        }

        if (collision.gameObject.tag == "Portal2" && time > 5)
        {
            // Update the reference to Portal2
            portal2 = GameObject.FindGameObjectWithTag("Portal1");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
        
            else
            {
                Debug.LogWarning("Portal2 not found.");
            }
        }
        time = 0;
    }
}

