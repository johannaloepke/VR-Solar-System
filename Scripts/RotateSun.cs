using UnityEngine;
using System.Collections;

public class RotateSun : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(obj.transform.position, Vector3.up, Time.deltaTime / 3);
    }
}
