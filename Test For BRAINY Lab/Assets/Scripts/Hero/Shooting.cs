using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : Shot
{
    [SerializeField] private GameObject _prefabBullet;
    [SerializeField] private Transform Gun;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
    }

    void Shot()
    {
        Shooting(Gun, _prefabBullet);
    }
}
