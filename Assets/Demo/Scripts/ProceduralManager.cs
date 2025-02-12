using UnityEngine;

public class ProceduralManager : MonoBehaviour
{
    public GridManager gridManager;
    public ProceduralGenerator proceduralGenerator;
    public GameObject Player;
    void Start()
    {
        if (proceduralGenerator != null)
        {
            proceduralGenerator.GenerateRoomAndCorridor();
            proceduralGenerator.SpawnPlayer(Player, GameObject.Find("Parent"));
            gridManager.enabled = true;
        }
        else
        {
            Debug.LogError("DungeonGenerator is not assigned!");
        }
    }
}
