using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("HolaMundo");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	 void OnMouseDown()
	{

        Destroy(gameObject);
		
	}
}
