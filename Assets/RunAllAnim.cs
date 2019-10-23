using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RunAllAnim : MonoBehaviour
{

    private float time = 1.5f;
    public GameObject BoostMenu;
    private Vector3 SaveTemp;
    public RectTransform asd;
    void Start()
    {
        //SaveTemp = new Vector3[BoostMenu.Length];
        //for (int i = 0; i < BoostMenu.Length; i++)
        {
            SaveTemp = BoostMenu.transform.position;
            BoostMenu.transform.position = new Vector3(1000, 0, 2000);
            BoostMenu.SetActive(true);
        }
    }

    void Update()
    {

        time -= Time.deltaTime;
        if (time <= 0.75f)
        {
            //for (int i = 0; i < BoostMenu.Length; i++)
            //{
            BoostMenu.transform.position = SaveTemp;
            asd.offsetMax = new Vector2(0, 0);
            asd.offsetMin = new Vector2(0, 0);
            BoostMenu.SetActive(false);
            //}
        }
        if (time <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}