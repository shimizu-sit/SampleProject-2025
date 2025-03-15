using UnityEngine;

public class Bumper : MonoBehaviour
{
  // float型でbounce変数を宣言し10を代入
  public float bounce = 10f;
  
  void OnCollisionEnter(Collision collision)
  {
    // 衝突した相手オブジェクトのRigidbodyを取得
    Rigidbody rb = collision.rigidbody;

    if(rb != null){
      // 衝突した相手オブジェクトのRigidbodyに力を加える
      // x軸方向には0の力を，Y軸方向にはbounce/4の力を，z軸方向にはbounceの力を加える
      // 力を瞬間的に加えるのでForceModeをImpulseに設定
      collision.rigidbody.AddForce(0f, bounce/4, bounce, ForceMode.Impulse);
    }
  }
}
