using UnityEngine;
using TMPro;

public class PlayerMoneyDisplay : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<PlayerMoney>().ChangeMoneyTextReference(GetComponent<TextMeshProUGUI>());
    }
}