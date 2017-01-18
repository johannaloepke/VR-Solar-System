using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(obj.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
