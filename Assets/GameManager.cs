using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	public static GameManager Instance;


	public int Score;
	public int HighScore;

	public Spawner Spawner;
	public Button StartButton;

	public GameObject Player;

	public Text ScoreText;
	public Text HighScoreText;

	public bool PlayerDead;
	

	void Awake()
	{
		Instance = this;
		LoadScores();
		StopGame();
	}
	
	// Use this for initialization
	void Start () {
		
	}

	public void StartGame()
	{
		PlayerDead = false;
		Spawner.enabled = true;
		Player.SetActive(true);
		StartButton.gameObject.SetActive(false);

		ScoreText.text = "0";
		Score = 0;
	}

	public void StopGame()
	{
		PlayerDead = true;
		StartButton.gameObject.SetActive(true);
		Player.SetActive(false);
		Spawner.enabled = false;

		SaveScores();
	}

	public void LoadScores()
	{
		HighScore = PlayerPrefs.GetInt("HighScore", 0);

		HighScoreText.text = HighScore.ToString();
	}

	public void SaveScores()
	{
		PlayerPrefs.SetInt("HighScore", HighScore);
	}
	
	public void ScoreUp()
	{
		if (!PlayerDead)
		{
			Score++;

			if (Score > HighScore)
			{
				HighScore = Score;
				HighScoreText.text = HighScore.ToString();
			}

			ScoreText.text = Score.ToString();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
