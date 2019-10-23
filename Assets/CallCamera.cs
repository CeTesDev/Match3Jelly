using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallCamera : MonoBehaviour {

    private MapCamera mCam;
	// Use this for initialization
	void Start () {
        mCam = FindObjectOfType<MapCamera>();
        mCam.ChangeCameraSize();

    }

    // Update is called once per frame
    void Update(){
        //mCam.SetPosition(new Vector2(0,2.3f));
    }
}
