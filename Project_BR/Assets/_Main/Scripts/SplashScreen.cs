using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

    public Sprite[] Logos;
    public float fadeTime;
    public Color ImageHolderColor;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private IEnumerator CycleLogo_cr(float fadeTime, Sprite Logo, Color ImageHolderColor)
    {
        //ImageHolder
        yield return null;
    }
}
