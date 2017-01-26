using UnityEngine;
using System.Collections;

// This script moves the player in the direction he is looking at. To activate the 
// movement, pull the cardboard trigger, and deactivate it by pulling again

public class Move : MonoBehaviour {

    private const int RIGHT_ANGLE = 90;

    // This variable determinates if the player will move or not 
    private bool isMoving = false;
    GvrHead head = null;

    // this is the variable for the speed the player moves at
    public float speed;

    // this is the variable for the cardboard trigger being pushed
    public bool triggerPushed;

    void Start()
    {
        head = Camera.main.GetComponent<StereoController>().Head;
    }

    void Update()
    {
        // Walk when the Cardboard Trigger is used 
        if (triggerPushed && !isMoving && GvrViewer.Instance.Triggered)
        {
            isMoving = true;
        }
        else if (triggerPushed && isMoving && GvrViewer.Instance.Triggered)
        {
            isMoving = false;
        }
        if (isWalking)
        {
            Vector3 direction = new Vector3(head.transform.forward.x, head.transform.forward.y, head.transform.forward.z).normalized * speed * Time.deltaTime;
            Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));
            transform.Translate(rotation * direction);
        }
    }
}
