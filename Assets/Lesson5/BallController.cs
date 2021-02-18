
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;

	//ゲームの総得点
	private int score = 0;

        //得点を表示するテキスト
        private GameObject scoreText;

	void Start()
	{
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");

                 this.scoreText = GameObject.Find("ScoreText");
         }

	void Update()
	{
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ)
		{
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text>().text = "Game Over";
		}
         }

	// 衝突時に呼ばれる関数
	void OnCollisionEnter(Collision collision)
	{
		// Debug.Log(collision.gameObject.name); //ぶつかった相手の名前を取得

		if (collision.gameObject.tag == "LargeStarTag")
		{
			score += 30;
			Debug.Log("score: " + score.ToString());
                 scoreText.GetComponent<Text>().text = score.ToString();
		}
		if (collision.gameObject.tag == "SmallStarTag")
		{
			score += 10;
			Debug.Log("score: " + score.ToString());
                 scoreText.GetComponent<Text>().text = score.ToString();
		}
                 if (collision.gameObject.tag == "LargeCloudTag")
		{
			score += 50;
			Debug.Log("score: " + score.ToString());
                 scoreText.GetComponent<Text>().text = score.ToString();
		}
                 if (collision.gameObject.tag == "SmallCloudTag")
		{
			score += 20;
			Debug.Log("score: " + score.ToString());
                 scoreText.GetComponent<Text>().text = score.ToString();
		}

        }
}