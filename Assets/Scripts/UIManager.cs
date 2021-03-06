using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _cointText;

    public void UpdateCoinDisplay(int coins)
    {
        _cointText.text = "Coins: " + coins.ToString();
    }
}
