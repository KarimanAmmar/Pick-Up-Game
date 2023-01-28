using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSystem.EndSystem;

namespace GameSystem
{
    namespace ColSystem
    {

        public class ColManager : MonoBehaviour
        {
            // Start is called before the first frame update

            [SerializeField] GameObject fakeitem;
            [SerializeField] EndGame end;
            [SerializeField] AudioSource sound;


            // Update is called once per frame
            void Update()
            {
                
            }
            void OnMouseDown()
            {
                // Debug.Log(this.name);
                Destroy(this.gameObject);

                Color tmp = fakeitem.GetComponent<SpriteRenderer>().color;
                tmp.a = 255f;
                fakeitem.GetComponent<SpriteRenderer>().color = tmp;
                end.Count++;
                sound.Play();
                
            }



        }

    }

}