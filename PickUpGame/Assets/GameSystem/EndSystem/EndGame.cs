using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



namespace GameSystem
{
    namespace EndSystem
    {

        public class EndGame : MonoBehaviour
        {
            // Start is called before the first frame update
           
            [SerializeField] GameObject panel;
           
            [SerializeField] AudioSource aud;
            [SerializeField] AudioClip clip;

            public int Count;



            void Start()
            {
               
            }

            // Update is called once per frame
            void Update()
            {
                EndGameScene();
            }
            void EndGameScene()
            {

                if (Count == 13)
                {
                    panel.SetActive(true);
                    ReLoad();
                    aud.PlayOneShot(clip);
                    Count = 0;
                }
                
            }

            public void ReLoad()
            {
                StartCoroutine(IsWaiting());  
            }


            IEnumerator IsWaiting()
            {
                yield return new WaitForSeconds(2);
                SceneManager.LoadScene("UI");
            }
            
        }

    }
}