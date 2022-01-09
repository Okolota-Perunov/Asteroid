using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchOnOrOff : MonoBehaviour
{
    [SerializeField] private GameObject Glitch_Go;
    protected float _timerVisibleAlpha;

    protected void Start()
    {

    }
    protected void Update()
    {
        if(_timerVisibleAlpha <= 0f)
        {
            _timerVisibleAlpha = Random.Range(0,100);
        }
        var AlphaGlitch = Glitch_Go.GetComponent<Renderer>().material;
        _timerVisibleAlpha -= Time.deltaTime;
        if(_timerVisibleAlpha <= 30)
        {
            AlphaGlitch.SetFloat("Alpha_",0.2f);
        }
        else
        {
            AlphaGlitch.SetFloat("Alpha_",0f); 
        }
        
    }
}
