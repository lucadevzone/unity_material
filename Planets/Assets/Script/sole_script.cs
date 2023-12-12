using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sole_script : MonoBehaviour
{

    [SerializeField]
    private float rot_sistema = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotazione_system = new Vector3(0, rot_sistema, 0);
        transform.Rotate(rotazione_system * Time.deltaTime);
    }
}
