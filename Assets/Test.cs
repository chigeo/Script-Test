using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = {13,32,8,16,34} ;
		for(int c = array.Length -1 ; 0 <= c; c--){
			Debug.Log(array[c]);
		}

	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
