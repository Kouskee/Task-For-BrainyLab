using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
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
        GameObject newBullet = Instantiate(_prefabBullet, Gun.transform.position, Gun.transform.localRotation);
        newBullet.transform.Translate(Gun.transform.forward * 2f);
        newBullet.GetComponent<Rigidbody>().velocity = Gun.transform.forward * 30f;
    }
}
