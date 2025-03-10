using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  // float型でspeed変数を宣言し15を代入
  public float speed = 15;

    void FixedUpdate()
    {
        // キー入力の取得と速度の計算
        var veloz = speed * Input.GetAxisRaw("Horizontal");

        // Rigidbodyコンポーネントを取得して速度を設定
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0f, 0f, -veloz);
    }
}
