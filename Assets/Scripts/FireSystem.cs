
using UnityEngine;
namespace WineGiraffe       
{ 
    public class FireSystem : MonoBehaviour 
    {
        [SerializeField, Header("�l�u�w�m��")]
        private GameObject prefabBullt;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

        //�ͦ��l�u
        protected void SpawnBullet()
        {
            Instantiate(prefabBullt, pointSpawn.position, pointSpawn.rotation);  
        }
 
    }
}   