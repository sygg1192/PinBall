﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	private GameObject gameoverText;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトの取得
		this.gameoverText = GameObject.Find("GameOverText");
		
	}
	
	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameOverTextにゲームオーバーを表示
			this.gameoverText.GetComponent<Text> ().text = "GameOver";
		}
	}
}