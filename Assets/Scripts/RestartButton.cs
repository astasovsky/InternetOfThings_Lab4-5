using UnityEngine;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private GameObject losePanel;

    
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(RespawnPlayer);
    }

    private void RespawnPlayer()
    {
        player.position = respawnPoint.position;
        losePanel.SetActive(false);
    }
}
