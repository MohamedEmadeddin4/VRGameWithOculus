using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeAnimation : MonoBehaviour
{
    #region Case Parameters
    [Header("Case LOGO")]
    public GameObject LogoApear;

    [Header("Case 1")]
    public Animator anim;
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    

    [Header("Case 2")]
    public GameObject InstructorTalk;
    public GameObject InstructorWalk;
    public Animator anim2;
    public Animator anim3;
    
    [Header("Case 3")]
    
    public GameObject QPanel;
    public GameObject CorrectPanel;
    public Animator anim4;
   
    

    [Header("Case 4")]
    
    public GameObject InCorrectPanel;
    public Animator anim5;
    


    #endregion
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCorLogo());
        StartCoroutine(StartFadeIn());
        StartCoroutine(StartFadeOut());
        StartCoroutine(StartaudioQ());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChoiceA()
    {
        anim5.Play("INCORRECTAnim");
        QPanel.SetActive(false);
        InCorrectPanel.SetActive(true);
        CorrectPanel.SetActive(false);
        anim3.Play("InstructorTalkIncorrect");
        audioSource.clip = audioClipArray[2];
        audioSource.Play();
        Debug.Log("A Choseen");
    }
    public void ChoiceB()
    {
        anim5.Play("INCORRECTAnim");
        QPanel.SetActive(false);
        InCorrectPanel.SetActive(true);
        CorrectPanel.SetActive(false);
        anim3.Play("InstructorTalkIncorrect");
        audioSource.clip = audioClipArray[2];
        audioSource.Play();
        Debug.Log("B Choseen");
    }
    public void ChoiceC()
    {
        anim4.Play("CorrectAnim");
        audioSource.clip = audioClipArray[1];
        audioSource.Play();
        QPanel.SetActive(false);
        CorrectPanel.SetActive(true);
        InCorrectPanel.SetActive(false);
        anim3.Play("InstructorTalkCorrect");
        Debug.Log("C Choseen");
    }
    
    public void PlayAgain()
    {
        
        SceneManager.LoadScene("Main_Scene");
        
        
    }
    public void ExitGame()
    {
        
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
        
    }

    IEnumerator StartCorLogo()
    {

        yield return new WaitForSeconds(3.0f);
        LogoApear.SetActive(false);
        Debug.Log("Coroutine Fade out");
    }
    IEnumerator StartFadeIn()
    {
        yield return new WaitForSeconds(4.0f);
        anim.Play("FadeIn");
        Debug.Log("Coroutine Fade In");
    }
    IEnumerator StartFadeOut()
    {

        yield return new WaitForSeconds(5.0f);
        anim.Play("FadeOut");
        InstructorWalk.SetActive(false);
        InstructorTalk.SetActive(true);
        anim3.Play("Talking_Idel");
        Debug.Log("Coroutine Fade out");
    }
    IEnumerator StartaudioQ()
    {

        yield return new WaitForSeconds(7.0f);
        audioSource.clip = audioClipArray[0];
        audioSource.Play();
        anim2.Play("LerpQ");
        Debug.Log("Coroutine Start Audio Q");
    }
    
}
