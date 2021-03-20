using UnityEngine;

public class SkinPanel : MonoBehaviour
{
    public GameObject skinToEquip;

    public void EquipSkin()
    {
        SkinLoader.skinToLoad = skinToEquip;
    }
}