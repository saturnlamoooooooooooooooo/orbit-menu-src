using UnityEngine;
using System.Collections;
using easyInputs;
using MelonLoader;
using UnityEngine.UI;

namespace IIDKQuest.Menu
{


    public static class MenuDrop
    {

        public static int currentDropType = 1; // 0=collidable,1=zeroG,2=delete,3=animated
        public static bool rightHanded = true;
        public enum DropType {  ZeroGravityd }

        public enum DropTypeS
        {
           
            ZeroGravity,
            
        }
        public static DropType currentDrop = DropType.ZeroGravityd;



        public static void DropZeroGravity(GameObject menu)
        {
            Rigidbody rb = menu.GetComponent<Rigidbody>();
            if (rb == null) rb = menu.AddComponent<Rigidbody>();

            rb.useGravity = false;
            rb.isKinematic = false;
            rb.drag = 0.2f;          // slows down movement gradually
            rb.angularDrag = 0.2f;   // slows down rotation gradually
            rb.mass = 0.1f;          // very light, floats easier

            // Start with a gentle random push
            rb.velocity = new Vector3(
                Random.Range(-0.2f, 0.2f),
                Random.Range(-0.2f, 0.2f),
                Random.Range(-0.2f, 0.2f)
            );

            // Add a little random spin
            rb.angularVelocity = new Vector3(
                Random.Range(-0.5f, 0.5f),
                Random.Range(-0.5f, 0.5f),
                Random.Range(-0.5f, 0.5f)
            ); UnityEngine.Object.Destroy(menu, 2f);
        }


     


        public class MonoBehaviourRunner : MonoBehaviour { }
    }
}
