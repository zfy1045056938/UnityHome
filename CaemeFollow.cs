using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaemeFollow : MonoBehaviour {

	GameObject pobject;

	// Use this for initialization
	void Start () {
		
		pobject = GameObject.FindGameObjectWithTag ("Player");


		//Get Position
		pobject.transform.position = pobject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
