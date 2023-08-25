using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gun : MonoBehaviour
{
    private CharacterInput controls;

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    void Awake()
    {
        controls = new CharacterInput();

        // Important updated section!!
        //If we do not have a camera object
        if (fpsCam == null)
        {
            //Go to the parent object, get the camera component
            fpsCam = transform.parent.gameObject.GetComponent<Camera>();
        }
    }
    void OnEnable()
    {
        controls.Enable();
    }
    void OnDisable()
    {
        controls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (controls.Player.Shoot.triggered)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            target enemy = hit.transform.GetComponent<target>();

            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
