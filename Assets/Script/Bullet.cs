using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _bulletAccelerarion = 5.0f;
    [SerializeField] private float _lifeTimeCount = 1.0f;

    private Vector3 _transformSpeed;

   void Update()
        {
			_transformSpeed += ( _bulletAccelerarion * ( transform.up * _bulletAccelerarion ) ) * Time.deltaTime;

			transform.Translate( _transformSpeed * Time.deltaTime, Space.World );
            _lifeTimeCount -= Time.deltaTime;
            if(_lifeTimeCount <= 0)
                {
                    Destroy(this.gameObject);
                }

        }
}
