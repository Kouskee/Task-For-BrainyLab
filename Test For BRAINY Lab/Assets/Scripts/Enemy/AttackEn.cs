using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEn : MonoBehaviour
{
    [SerializeField] private Transform _gun;
    [SerializeField] private Transform _hero;
    [SerializeField] private GameObject _prefabBullet;
    [SerializeField] private FollowToHero followToHero;

    bool canShoot = true;

    void Update()
    {
        if(_hero != null) 
        { 
            RaycastHit hit;
            Ray ray = new Ray(_gun.position, _gun.forward);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.collider.transform == _hero)
                {
                    followToHero.obstacle = false;
                    if (canShoot)
                        StartCoroutine(Shot());
                }
            }
            if(Physics.Raycast(_gun.position, _hero.position, out hit, 100f))
            {
                if (hit.collider.transform != _hero)
                    followToHero.obstacle = true;  
            }
        }
    }

    IEnumerator Shot()
    {
        canShoot = false;
        GameObject newBullet = Instantiate(_prefabBullet, _gun.transform.position, _gun.transform.localRotation);
        newBullet.transform.Translate(_gun.transform.forward * 2f);
        newBullet.GetComponent<Rigidbody>().velocity = _gun.transform.forward * 30f;
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }
    
}
