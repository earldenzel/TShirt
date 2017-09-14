using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShirtChanger : MonoBehaviour {

    public GameObject shirt;
    public Sprite shirtChange;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        shirt.GetComponent<SpriteRenderer>().sprite = shirtChange;
    }
}
