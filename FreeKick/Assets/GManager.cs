using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour {
    public GameObject B_Luo_playerObj;
	// Use this for initialization
	void Start () {
        GSetting.StrCurPlayerName = "";
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void SetPlayerObj(string Name)
    {
        if (Name == GSetting.StrCurPlayerName) {
            return;
        } else if (Name==GSetting.scorePlayerName_1) {
            Destroy(GSetting.ObjCurPlayer);
            Vector3 pos = new Vector3(200f, 60.5f, -5f);
            Instantiate(B_Luo_playerObj, pos,Quaternion.identity);
            GSetting.StrCurPlayerName = GSetting.scorePlayerName_1;
        }

    }

   public void SetBLUO() {
        SetPlayerObj(GSetting.scorePlayerName_1);
    }

}
