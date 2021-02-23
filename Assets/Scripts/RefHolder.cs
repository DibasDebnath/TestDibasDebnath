using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefHolder : MonoBehaviour
{
    public static RefHolder instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public GamePlay gamePlay;
    public PlayerController playerCon;
    public UICon uICon;
    public AudioController audioController;
    //public PlayerDataManager dataManager;
}
