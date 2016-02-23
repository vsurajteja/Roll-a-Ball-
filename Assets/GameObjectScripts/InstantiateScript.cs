using UnityEngine;
using System.Collections;

public class InstantiateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    GameObject.Instantiate(Resources.Load("Clone"), gameObject.transform.position,this.transform.rotation);
	}

    public void TestMethod()
    {
        Debug.Log("For Testing Purpose only");
    }

}
