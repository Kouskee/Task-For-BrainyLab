using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEn : Shot
{
    [SerializeField] private Transform _gun;
    [SerializeField] private Transform _hero;
    [SerializeField] private GameObject _prefabBullet;

    bool canShoot = true;

    void Update()
    {
        if(_hero != null) 
        { 
            RaycastHit hit;
            Ray ray = new Ray(_gun.position, _gun.forward);
            if (Physics.Raycast(ray, out hit, 100f))
                if (hit.collider.transform == _hero)
                    if (canShoot)
                        StartCoroutine(Shot());
        }
    }

    IEnumerator Shot()
    {
        canShoot = false;
        Shooting(_gun, _prefabBullet);
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }
    
}
