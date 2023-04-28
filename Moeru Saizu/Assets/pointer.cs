using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    public GameObject pointer_obj;
    //public Transform pointer_pos;

    // Start is called before the first frame update
    void Start()
    {
        //pointer_pos = pointer_obj.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                pointer_obj.transform.position = hit.point;
            }
        }
    }
}
