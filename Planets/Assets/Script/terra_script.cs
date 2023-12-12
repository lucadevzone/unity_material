using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terra_script : MonoBehaviour
{

    [SerializeField]
    private float rot_speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(0, rot_speed, 0);
        transform.Rotate(rotation * Time.deltaTime);
    }
}
