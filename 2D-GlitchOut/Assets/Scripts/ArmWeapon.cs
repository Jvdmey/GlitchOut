using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmWeapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject lazerBulletPrefab;
    CharacterController refCharacterController;

    private void Start()
    {
        refCharacterController = gameObject.GetComponent<CharacterController>();
    
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if(refCharacterController.movementDirection.x > 0)
        {
            //firepoint moves here
        }
        void Shoot()
        {
            Instantiate(lazerBulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
