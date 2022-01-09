using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapScreen : TeleportOnScreen 
{
	
		public override void Update() 
        {
			base.Update();

			if( _isOffScreen ) 
			{
				transform.position = Camera.main.ViewportToWorldPoint( _viewportPos );
			}
		}
}
