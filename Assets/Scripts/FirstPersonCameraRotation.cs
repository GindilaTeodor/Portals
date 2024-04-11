using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCameraRotation : MonoBehaviour
{
    [SerializeField]
    public GameObject firstPortalPrefab; // Prefab for the first portal
    [SerializeField]
    public GameObject secondPortalPrefab; // Prefab for the second portal

    public float Sensitivity
    {
        get { return sensitivity; }
        set { sensitivity = value; }
    }
    [Range(0.1f, 9f)]
    [SerializeField] float sensitivity = 2f;
    [Tooltip("Limits vertical camera rotation. Prevents the flipping that happens when rotation goes above 90.")]
    [Range(0f, 90f)]
    [SerializeField] float yRotationLimit = 88f;

    Vector2 rotation = Vector2.zero;
    const string xAxis = "Mouse X";
    const string yAxis = "Mouse Y";

    // Start is called before the first frame update
    void Start()
    {
        // Set Cursor to not be visible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Handle camera rotation
        HandleRotation();

        // Check for left click
        if (Input.GetMouseButtonDown(0))
        {
            PerformLeftClickAction();
        }

        // Check for right click
        if (Input.GetMouseButtonDown(1))
        {
            PerformRightClickAction();
        }
    }

    void HandleRotation()
    {
        rotation.x += Input.GetAxis(xAxis) * sensitivity;
        rotation.y += Input.GetAxis(yAxis) * sensitivity;
        rotation.y = Mathf.Clamp(rotation.y, -yRotationLimit, yRotationLimit);
        var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left);

        transform.localRotation = xQuat * yQuat;
    }

    void PerformLeftClickAction()
    {
        DestroyPortalIfExists1();

        // Perform raycast on left click
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            // Instantiate the first portal prefab at the hit point
            GameObject portal = Instantiate(firstPortalPrefab, hit.point, Quaternion.identity);

            // Calculate rotation to face the player and rotate 90 degrees in the X-axis
            Vector3 playerDirection = transform.position - hit.point;
            Quaternion playerRotation = Quaternion.LookRotation(playerDirection);
            playerRotation *= Quaternion.Euler(0, -90, 0); // Rotate 90 degrees in the X-axis

            // Apply rotation to face the player
            portal.transform.rotation = playerRotation;
        }
    }

    void PerformRightClickAction()
    {
        DestroyPortalIfExists2();

        // Perform raycast on right click
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            // Instantiate the second portal prefab at the hit point
            GameObject portal = Instantiate(secondPortalPrefab, hit.point, Quaternion.identity);

            // Calculate rotation to face the player and rotate 90 degrees in the X-axis
            Vector3 playerDirection = transform.position - hit.point;
            Quaternion playerRotation = Quaternion.LookRotation(playerDirection);
            playerRotation *= Quaternion.Euler(0, -90, 0); // Rotate 90 degrees in the X-axis

            // Apply rotation to face the player
            portal.transform.rotation = playerRotation;
        }
    }

    void DestroyPortalIfExists1()
    {
        GameObject existingPortal = GameObject.FindWithTag("Portal1");
        if (existingPortal != null)
        {
            Destroy(existingPortal);
        }
    }

        void DestroyPortalIfExists2()
        {
            GameObject existingPortal = GameObject.FindWithTag("Portal2");
            if (existingPortal != null)
            {
                Destroy(existingPortal);
            }
        }
    }
