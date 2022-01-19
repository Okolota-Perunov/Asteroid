using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnScreen : MonoBehaviour
{
    
	[SerializeField] private float _padding = 0.1f;

	protected bool _isOffScreen;
	protected Vector3 _viewportPos;

	private float _top;
	private float _bottom;
	private float _left;
	private float _right;

	public virtual void Awake() 
        {
		_top = 0.0f - _padding;
		_bottom = 1.0f + _padding;
		_left = 0.0f - _padding;
		_right = 1.0f + _padding;
	}
	
	public virtual void Update() 
        {
		_viewportPos = Camera.main.WorldToViewportPoint( transform.position );
		
		_isOffScreen = false;

		if( _viewportPos.x < _left ) 
            	{
			_viewportPos.x = _right;
			
			_isOffScreen = true;
		}

            	else if( _viewportPos.x > _right ) 
		{
			_viewportPos.x = _left;
			_isOffScreen = true;
		}

		if( _viewportPos.y < _top ) 
            	{
			_viewportPos.y = _bottom;
			_isOffScreen = true;
		}

            	else if( _viewportPos.y > _bottom ) 
            	{
			_viewportPos.y = _top;
			_isOffScreen = true;
		}
	}
	
}
