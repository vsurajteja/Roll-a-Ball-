﻿using UnityEngine;
using System.Collections;

public class Rotate1 : MonoBehaviour {


	//This method rotates the cubes
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}

    public void UselessMethod()
    {
        for (int i = 0; i < int.MaxValue; i++)
        {
            //do nothing
        }
    }


}

