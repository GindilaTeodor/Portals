using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCollider : MonoBehaviour
{

    float time = 3;
    private GameObject portal2; // Reference to the second portal
    [SerializeField]    
    private float distancePortal;
    public AudioClip warpAudioClip;
    private SoundManager audioManager;

    void Start()
    {
        audioManager = FindObjectOfType<SoundManager>();
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Portal1" && time > 3)
        {
            audioManager.PlaySound(warpAudioClip);
            // Update the reference to Portal2
            portal2 = GameObject.FindGameObjectWithTag("Portal2");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                Vector3 directionFromPortal = portal2.transform.forward;

                // Calculate the position in front of the portal
                Vector3 newPosition = portal2.transform.position + (directionFromPortal * distancePortal);

                // Teleport the player to the new position
                transform.position = newPosition; ;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal2Ground");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal2Ceiling");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            else
            {
                Debug.LogWarning("Portal2 not found.");
            }
            time = 0;
        }
        if (collision.gameObject.tag == "Portal1Ground" && time > 3)
        {
            // Update the reference to Portal2
            audioManager.PlaySound(warpAudioClip);
            portal2 = GameObject.FindGameObjectWithTag("Portal2");

            if (portal2 != null)
            {
                Vector3 directionFromPortal = portal2.transform.forward;

                // Calculate the position in front of the portal
                Vector3 newPosition = portal2.transform.position + (directionFromPortal * distancePortal);

                // Teleport the player to the new position
                transform.position = newPosition;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal2Ground");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal2Ceiling");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            else
            {
                Debug.LogWarning("Portal2 not found.");
            }
            time = 0;
        }
        if (collision.gameObject.tag == "Portal1Ceiling" && time > 3)
        {
            // Update the reference to Portal2
            audioManager.PlaySound(warpAudioClip);
            portal2 = GameObject.FindGameObjectWithTag("Portal2");

            if (portal2 != null)
            {
                Vector3 directionFromPortal = portal2.transform.forward;

                // Calculate the position in front of the portal
                Vector3 newPosition = portal2.transform.position + (directionFromPortal * distancePortal);

                // Teleport the player to the new position
                transform.position = newPosition;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal2Ground");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal2Ceiling");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            else
            {
                Debug.LogWarning("Portal2 not found.");
            }
            time = 0;
        }
        if (collision.gameObject.tag == "Portal2" && time > 3)
        {
            // Update the reference to Portal2
            audioManager.PlaySound(warpAudioClip);
            portal2 = GameObject.FindGameObjectWithTag("Portal1");

            if (portal2 != null)
            {
                Vector3 directionFromPortal = portal2.transform.forward;

                // Calculate the position in front of the portal
                Vector3 newPosition = portal2.transform.position + (directionFromPortal * distancePortal);

                // Teleport the player to the new position
                transform.position = newPosition;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal1Ground");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal1Ceiling");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            else
            {
                Debug.LogWarning("Portal2 not found.");
            }
            time = 0;
        }
        if (collision.gameObject.tag == "Portal2Ceiling" && time > 3)
        {
            // Update the reference to Portal2
            audioManager.PlaySound(warpAudioClip);
            portal2 = GameObject.FindGameObjectWithTag("Portal1");

            if (portal2 != null)
            {
                Vector3 directionFromPortal = portal2.transform.forward;

                // Calculate the position in front of the portal
                Vector3 newPosition = portal2.transform.position + (directionFromPortal * distancePortal);

                // Teleport the player to the new position
                transform.position = newPosition;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal1Ground");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal1Ceiling");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            else
            {
                Debug.LogWarning("Portal2 not found.");
            }
            time = 0;
        }
        if (collision.gameObject.tag == "Portal2Ground" && time > 3)
        {
            // Update the reference to Portal2
            audioManager.PlaySound(warpAudioClip);
            portal2 = GameObject.FindGameObjectWithTag("Portal1");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                Vector3 directionFromPortal = portal2.transform.forward;

                // Calculate the position in front of the portal
                Vector3 newPosition = portal2.transform.position + (directionFromPortal * distancePortal);

                // Teleport the player to the new position
                transform.position = newPosition;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal1Ground");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            portal2 = GameObject.FindGameObjectWithTag("Portal1Ceiling");

            if (portal2 != null)
            {
                // Teleport the player to the position of Portal2
                transform.position = portal2.transform.position;
            }
            else
            {
                Debug.LogWarning("Portal2 not found.");
            }
            time = 0;
        }
        if (collision.gameObject.tag == "Death")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.tag == "Finish")
        {
           
            Destroy(this);
            SceneManager.LoadScene("StartScene");
        }
    }
}


