using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]private TMP_Text _liveText;
    [SerializeField]private IntValue _playerLife;

    private void Update()
    {
        _liveText.SetText("Player lives: " + _playerLife.value);
    }

    public void ReactToPlayerDeath()
    {
        Debug.Log("ReactToPlayerDeath");
    }
    
}