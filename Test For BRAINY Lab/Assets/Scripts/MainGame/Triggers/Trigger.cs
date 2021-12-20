using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other?.GetComponent<Rigidbody>())
            Destroy(other.gameObject);
    }
}
