
using UnityEngine;
namespace WineGiraffe       
{ 
    public class FireSystem : MonoBehaviour 
    {
        [SerializeField, Header("子彈預置物")]
        private GameObject prefabBullt;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;

        //生成子彈
        protected void SpawnBullet()
        {
            Instantiate(prefabBullt, pointSpawn.position, pointSpawn.rotation);  
        }
 
    }
}   