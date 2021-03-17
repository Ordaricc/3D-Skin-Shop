using UnityEngine;

public class PlayerModelLoader : MonoBehaviour
{
    [SerializeField] private GameObject placeholderModel;

    public static GameObject playerModelToInstantiate;

    private void Awake()
    {
        if (playerModelToInstantiate != null)
        {
            //destroy placeholder
            Destroy(placeholderModel);

            //instantiate the player model
            Instantiate(playerModelToInstantiate, transform);
        }
    }
}