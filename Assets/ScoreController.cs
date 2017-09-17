using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ScoreController : MonoBehaviour{
	
	public Text ScoreText; //Text用変数
	private int score = 0; //スコア計算用変数

	void Start()
	{
		score   = 0;
		SetScore();   //初期スコアを代入して表示
	}
		
	void OnCollisionEnter( Collision collision )
	{
		string yourTag  = collision.gameObject.tag;

		if( yourTag == "LargeStarTag" )
		{
			score += 150;
		}
		else if( yourTag == "LargeCloudTag" )
		{
			score += 150;
		}
		else if( yourTag == "SmallCloudTag" )
		{
			score += 100;
		}
		else
		{
			score += 0;
		}

		SetScore();
	}

	void SetScore()
	{
		ScoreText.text = string.Format( "Score:{0}", score );
	}
}