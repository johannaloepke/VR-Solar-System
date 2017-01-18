using UnityEngine;
using System.Collections;

public class RotateSunVenus : MonoBehaviour {

    public GameObject obj;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(obj.transform.position, Vector3.up, 2 * Time.deltaTime);

    }
}
