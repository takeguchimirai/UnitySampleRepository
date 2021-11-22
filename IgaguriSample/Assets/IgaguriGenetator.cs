using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenetator : MonoBehaviour
{
    public GameObject igaguriPrefab;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri =
                Instantiate(igaguriPrefab) as GameObject;
            igaguri.GetComponent<IgaguriController>().Shoot(
                new Vector3(0, 200, 2000));

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<IgaguriController>().Shoot(
                worldDir.normalized * 2000);
        }
    }
}