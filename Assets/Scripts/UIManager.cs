using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager UIInstance;
    public Transform PlayerUI;
    public GameObject EnterStoreMessagePanel;
    public GameObject StorePanel;

    private void Awake()
    {
        UIInstance = this;
    }

   /* public void EnterStoreMessage()
    {
        EnterStoreMessagePanel.SetActive(true);
    }*/
    public void RefreshUI()
    {
        for (int i = 0; i < GameController.GameInstance.ActivePlayerList.Count; i++)    // Loop through the amount of players
        {
            int shiftedIndex = (i + GameController.GameInstance.currentPlayerIndex) % GameController.GameInstance.ActivePlayerList.Count;  // Index of the current player. We shift it to make sure the UI rotates based on the turn number
            Player currentplayer = GameController.GameInstance.ActivePlayerList[shiftedIndex];
            PlayerUI.GetChild(i).GetChild(0).GetComponent<TMP_Text>().text = currentplayer.name;
            PlayerUI.GetChild(i).GetChild(1).GetComponent<TMP_Text>().text = "Coins: " + currentplayer.Coins;
        }
    }


    public void EnterStoreUIState()
    {
        EnterStoreMessagePanel.SetActive(true);
        GameController.GameInstance.ChangeState(new UIState());
    }

    public void LeaveStoreUIState()
    {
        EnterStoreMessagePanel.SetActive(false);
        StorePanel.SetActive(false);
        GameController.GameInstance.ChangeState(new MoveState());
    }

    public void EnterStore()
    {
        StorePanel.SetActive(true);
        EnterStoreMessagePanel.SetActive(false);
    }
}
