using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Canvas OnePlayer_Select;
    public Canvas TwoPlayer_Select;
    public Canvas ThreePlayer_Select;
    public Canvas FourPlayer_Select;

    public Canvas MultiplayerSelect;
    
    //--------------------------------------------------------------------------
    //                           Menu Select
    //--------------------------------------------------------------------------

    //1 Player
    public void OnePlayer_Menu()
    {
        OnePlayer_Select.gameObject.SetActive(true);
    }

    //2 Player
    public void TwoPlayer_Menu()
    {
        TwoPlayer_Select.gameObject.SetActive(true);
    }

    //3 Player
    public void ThreePlayer_Menu()
    {
        ThreePlayer_Select.gameObject.SetActive(true);
    }

    //4 Player
    public void FourPlayer_Menu()
    {
        FourPlayer_Select.gameObject.SetActive(true);
    }

    public void MultiplayerMenu()
    {
        MultiplayerSelect.gameObject.SetActive(true);
    }

    //-------------------------------------------------------------------------
    //                       Back Buttons to those Menu
    //-------------------------------------------------------------------------

    public void OP_Back()
    {
        OnePlayer_Select.gameObject.SetActive(false);
    }

    public void TP_Back()
    {
        TwoPlayer_Select.gameObject.SetActive(false);
    }

    public void ThP_Back()
    {
        ThreePlayer_Select.gameObject.SetActive(false);
    }

    public void FP_Back()
    {
        FourPlayer_Select.gameObject.SetActive(false);
    }

    public void MM_Back()
    {
        MultiplayerSelect.gameObject.SetActive(false);
    }
}
