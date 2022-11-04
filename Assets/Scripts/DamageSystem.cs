
using UnityEngine;
namespace WineGiraffe 
{ 
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("報至預置物")]
        private GameObject prefabExplosion;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("碰撞:" + collision.gameObject);

            if (collision.gameObject.name.Contains(nameTarget)) 
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                Destroy(gameObject);
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }   
}