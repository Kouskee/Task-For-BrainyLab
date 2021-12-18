using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerLine : MonoBehaviour
{
    LineRenderer line;
    [SerializeField] private Transform gun;
    [SerializeField] private float gunRange = 50;
    [SerializeField] private Transform Hero;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        int ignoreBullets = 1 << 3;
        ignoreBullets = ~ignoreBullets;

        line.SetPosition(0, gun.position);

        Vector3 rayOrigin = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(gun.position, gun.forward, out hit, gunRange, ignoreBullets))
            line.SetPosition(1, hit.point);
        else
            line.SetPosition(1, rayOrigin + (Hero.forward * gunRange));
    }
}
