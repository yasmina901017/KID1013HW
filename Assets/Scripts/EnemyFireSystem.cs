
using UnityEngine;
namespace WineGiraffe
{ 
    public class EnemyFireSystem : MonoBehaviour
    {
        [SerializeField, Header("�ͦ����j"), Range(0, 3)]
        private float interval = 1.5f;
        private void Awake()
        {
            //�I�s�ۭq��k
            //SpawnBullet();

            //����I�s�]�w
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}