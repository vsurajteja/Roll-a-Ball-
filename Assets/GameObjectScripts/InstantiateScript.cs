using UnityEngine;
using System.Collections;

public class InstantiateScript : MonoBehaviour {

    public int i = 0;

	// Use this for initialization
	void Start () {
	
	}

  public void newMethodINJavaStyle()
  { }
	
	// Update is called once per frame
	void Update () {
    GameObject.Instantiate(Resources.Load("Clone"), gameObject.transform.position,this.transform.rotation);
        i++;
	}

    public void TestMethod()
    {
        Debug.Log("For Testing Purpose only");
    }

  public void NaveenMeth()
  {
    int i = 5;
    Debug.Log("okay ippatikyna ardam aynda?");
  }

  public void InkaIntikiveldamPadandi()
  { }


    public void TestMethod2()
    {
        Debug.Log("For Testing Purpose only");
    }

    public void xyz()
    {
        Debug.Log("For Testingdj Purpose only");
    }

    public void GameMethod()
    { }

    public void sdfsdfMethod()
    { }

  public void plsMohan()
  { }


    public void ForSmartGitTestingPurposeMethod()
    { }

}
