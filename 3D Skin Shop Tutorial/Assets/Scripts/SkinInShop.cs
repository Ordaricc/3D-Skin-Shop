using UnityEngine;

public class SkinInShop : MonoBehaviour
{
    [SerializeField] private GameObject playerModelPrefab;

    public void EquipSkin()
    {
        PlayerModelLoader.playerModelToInstantiate = playerModelPrefab;
    }
}