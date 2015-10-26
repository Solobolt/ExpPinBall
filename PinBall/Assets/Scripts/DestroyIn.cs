using UnityEngine;
using System.Collections;

public class DestroyIn : MonoBehaviour {

    public float lifeSpan = 3.0f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject,lifeSpan);
    }
}
