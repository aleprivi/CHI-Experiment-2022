using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {

            float x = Random.Range(0, 10);
            float y = Random.Range(0, 10);
            float z = Random.Range(0, 10);

            float r_x = Random.Range(0, 40);
            float r_y = Random.Range(0, 360);
            float r_z = Random.Range(0, 40);

            Vector3 tmp = new Vector3(x, y, z);
            Vector3 tmp_rot = new Vector3(r_x, r_y, r_z);

            this.transform.position = tmp;
            this.transform.Rotate(tmp_rot);

        }
    }
}
