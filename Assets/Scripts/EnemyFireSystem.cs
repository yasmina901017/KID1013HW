
using UnityEngine;
namespace WineGiraffe
{ 
    public class EnemyFireSystem : MonoBehaviour
    {
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;
        private void Awake()
        {
            //呼叫自訂方法
            //SpawnBullet();

            //延遲呼叫設定
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}