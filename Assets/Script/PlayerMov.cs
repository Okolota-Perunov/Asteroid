using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
		[SerializeField] private float _acceleration = 5.0f;

		[SerializeField] private float _maxSpeed = 5.0f;

		[SerializeField] private float _rotationSpeed = 100.0f;
		


        private float _friction = 1f;
		private Vector3 _transformSpeed;


		void Awake() 
        {
			Reset();
		}
		
		void Update() 
        {
			float inputX = Input.GetAxis( "Horizontal" );
			float inputY = Mathf.Clamp( Input.GetAxis( "Vertical" ), 0, 1 );

			transform.Rotate( new Vector3 ( 0, 0, -inputX ), _rotationSpeed * Time.deltaTime );

			_transformSpeed += ( inputY * ( transform.up * _acceleration ) ) * Time.deltaTime;
			_transformSpeed *= _friction;

			_transformSpeed = Vector3.ClampMagnitude( _transformSpeed, _maxSpeed );
			transform.Translate( _transformSpeed * Time.deltaTime, Space.World );
		}

		public void Reset() 
        {
			_transformSpeed = new Vector3( 0, 0, 0 );
		}
}
