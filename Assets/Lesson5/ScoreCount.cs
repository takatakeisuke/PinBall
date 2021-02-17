using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
  // 衝突時に呼ばれる関数
     void OnCollisionEnter(Collision collision)
   {
      Debug.Log(collision.gameObject.name); //ぶつかった相手の名前を取得
   }
}
