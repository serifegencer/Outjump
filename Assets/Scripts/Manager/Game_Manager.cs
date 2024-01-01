using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] private GameObject _levelUpdatePanel;
    
   [SerializeField] private Image[]  _stars;

   public bool _isStart;
   public bool _isComplete;
   public int _starCount;
   private int _currentLevelIndex;

    void Start()
    {
        _isStart = false;
        _isComplete = false;
        _currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
    }

    
    void Update()
    {
        for(int i = 0; i < _starCount; i++) {
            _stars[i].enabled = true ;
        }
    }

    public void LevelUpdatePanel(){
        _levelUpdatePanel.SetActive(true);
    }

    public void LevelUpdate(){
        SceneManager.LoadScene(_currentLevelIndex + 1);
    }

    public void GameOver() {
      SceneManager.LoadScene(_currentLevelIndex);
    }
}
