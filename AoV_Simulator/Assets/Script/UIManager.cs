using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject ArcanaUI;
    public GameObject BuildUI;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}



    public void MenuButtonPressed(string menu) {
        
        switch (menu) {
            case "arcana":
                Debug.Log("Switch Arcana Menu");
                ArcanaUI.SetActive(true);
                BuildUI.SetActive(false);
                break;
            case "build":
                ArcanaUI.SetActive(false);
                BuildUI.SetActive(true);
                Debug.Log("Switch Build Menu");
                break;
            default:
                Debug.Log("Other");
                break;
        }
    }

}
