using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject ArcanaUI;
    public GameObject BuildUI;
    public GameObject SelectionPanel;

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

    int selected_arcana;
    public void RedArcanaIconClicked(int num){
        Debug.Log("Red Arcana Clicked");
        //Open Selection Window
        SelectionPanel.SetActive(true);
        selected_arcana = num;
    }
    public void VioletArcanaIconClicked(int num){
        Debug.Log("Violet Arcana Clicked");
    }
    public void GreenArcanaIconClicked(int num){
        Debug.Log("Gren Arcana Clicked");
    }

}

public class ArcanaIcon{
    public void onClicked(){

    }

}
