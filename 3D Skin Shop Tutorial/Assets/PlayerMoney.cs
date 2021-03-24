using UnityEngine;
using TMPro;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int currentMoney;
    public TextMeshProUGUI moneyText;

    private void Awake()
    {
        currentMoney = PlayerPrefs.GetInt("prefMoney");
        OnMoneyAmountChange();
    }

    public void AddMoney(int moneyAmountToAdd)
    {
        currentMoney += moneyAmountToAdd;
        OnMoneyAmountChange();
    }

    public bool TryRemoveMoney(int moneyToRemove)
    {
        if (currentMoney >= moneyToRemove)
        {
            currentMoney -= moneyToRemove;
            OnMoneyAmountChange();
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnMoneyAmountChange()
    {
        PlayerPrefs.SetInt("prefMoney", currentMoney);
        moneyText.text = currentMoney + " G";
    }

    public void ChangeMoneyTextReference(TextMeshProUGUI newTextReference)
    {
        moneyText = newTextReference;
        moneyText.text = currentMoney + " G";
    }
}