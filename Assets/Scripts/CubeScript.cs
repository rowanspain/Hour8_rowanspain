using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private GameObject targetCube;
    // Start is called before the first frame update
    void Start()
    {
        targetCube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        targetCube.transform.Translate(.05f, 0f, 0f);
        targetCube.transform.Rotate(0f, 0f, 1f);
        targetCube.transform.localScale = new Vector3(4f, 4f, 4f);
    }
}
