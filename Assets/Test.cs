using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public bool Magic(){

        bool mpExhausted = false;

        if (this.mp >= 5){
            this.mp = this.mp - 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "だ");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
            mpExhausted = true;
        }
        return mpExhausted;
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        bool mpExhausted = false;

        for (int i = 1; !mpExhausted; i++){
            mpExhausted = lastboss.Magic();
            if(i==10){
                Debug.Log("魔法攻撃10回実行");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}