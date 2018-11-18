using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSetting : MonoBehaviour {

    public static string scorePlayerName_1 = "B罗";
    public static string scorePlayerName_2 = "梅西";

    public static string StrCurPlayerName;
    public static GameObject ObjCurPlayer;
    public static string StrCurBallName;

    public class PlayerObject
    {
        GameObject obj;
        string Name;
        int Power;
        int Master;
        int accuracy;
    }

    public class BallObejct
    {
        GameObject obj;
        int Speed;
        int Weight;
        //int ;
    }

    public class GoalKeeperObject
    {
        GameObject obj;
    }

}
