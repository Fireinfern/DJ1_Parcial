using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ENEMYTYPE{
    DEFAULT,
    BROWN,
    CREAM,
    FLY,
    RED,
    YELLOW
}

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private ENEMYTYPE enemyType = ENEMYTYPE.DEFAULT;

    void OnTriggerEnter2D(Collider2D other){
        //Debug.Log(other.tag);
        if(other.tag == "Player")
        {
            EnemyEffect();
            Destroy(this.gameObject);
        }
        if(other.tag == "EnemyDestroyer"){
            Destroy(this.gameObject);
        }
    }

    private void EnemyEffect()
    {
        switch (enemyType)
        {
            case ENEMYTYPE.BROWN:
                GameManager.instance.deductLives(1);
                break;
            case ENEMYTYPE.CREAM:
            case ENEMYTYPE.YELLOW:
                GameManager.instance.awardPoints(10);
                break;
            case ENEMYTYPE.FLY:
                GameManager.instance.deductLives(2);
                break;
            case ENEMYTYPE.RED:
                GameManager.instance.deductLives(100);
                break;
        }
    }
}
