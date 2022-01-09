using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _shotingPlace;
    [SerializeField] private Transform _shipTransform;

    private GameObject _bullet;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
            {
                _bullet = Instantiate(_bulletPrefab,new Vector3(_shotingPlace.position.x,_shotingPlace.position.y,_shotingPlace.position.z), _shipTransform.rotation);
            }
    }
}
