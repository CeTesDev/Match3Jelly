using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestory : MonoBehaviour {

    public GameObject [] obj;
    GameObject temp;
    // Use this for initialization
    void Start () {
        StartCoroutine("destory");
    }
	
	IEnumerator destory()
    {


        foreach(GameObject ga in obj)
        {
            temp = Instantiate(ga, transform.position, transform.rotation);
            Destroy(temp);
        }
        yield return new WaitForSeconds(1.0f);
    }
}
