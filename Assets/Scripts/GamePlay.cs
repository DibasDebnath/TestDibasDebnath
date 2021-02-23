using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Texts")]

    public GameObject omgText;
    public GameObject tissueText;
    public GameObject cleanText;
    public GameObject truckText;
    public GameObject doneText;


    [Header("Objects")]
    public GameObject playButton;

    public GameObject iceCream;
    public GameObject dustbin;
    public GameObject tissue;
    public GameObject truck;

    public bool tissueFound;


    void Start()
    {
        RefHolder.instance.playerCon.takeInput = false;
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        RefHolder.instance.playerCon.takeInput = true;
        playButton.SetActive(false);
        omgText.SetActive(true);
        iceCream.SetActive(true);
        tissue.SetActive(true);
        doneText.SetActive(false);
        tissueFound = false;
    }


    public void FoundTissue()
    {
        RefHolder.instance.audioController.Play(RefHolder.instance.audioController.Tap, false);
        omgText.SetActive(false);
        tissueText.SetActive(true);
        tissue.SetActive(false);
        tissueFound = true;
    }

    public void CleanIce()
    {
        RefHolder.instance.audioController.Play(RefHolder.instance.audioController.Tap, false);
        tissueText.SetActive(false);
        iceCream.SetActive(false);
        cleanText.SetActive(true);
        dustbin.SetActive(true);

    }


    public void DustbinFound()
    {
        RefHolder.instance.audioController.Play(RefHolder.instance.audioController.Tap, false);
        cleanText.SetActive(false);
        dustbin.SetActive(false);
        truckText.SetActive(true);
        truck.SetActive(true);
    }


    public void TruckFound()
    {
        RefHolder.instance.audioController.Play(RefHolder.instance.audioController.Tap, false);
        truckText.SetActive(false);
        doneText.SetActive(true);
        truck.SetActive(false);
        RefHolder.instance.playerCon.takeInput = false;
        //playButton.SetActive(true);
    }

    

}
