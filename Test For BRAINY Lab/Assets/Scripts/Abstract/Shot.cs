
using UnityEngine;

public abstract class Shot : MonoBehaviour
{
    protected virtual void Shooting(Transform _gun, GameObject _prefabBullet)
    {
        GameObject newBullet = Instantiate(_prefabBullet, _gun.transform.position, _gun.transform.localRotation);
        newBullet.transform.Translate(_gun.transform.forward * 2f);
        newBullet.GetComponent<Rigidbody>().velocity = _gun.transform.forward * 30f;
    }
}
