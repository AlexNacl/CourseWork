using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
    

public class DialogManager : MonoBehaviour
{
    public AudioMixer mixer;
    public Text dialogText;
    public bool ifNextScene;
    public Animator animator;
    public Animator Roboanimator;
    public Animator AngryRoboanimator;
    public GameObject Back;

    private Queue<string> sentences;

    public void Awake(){
        mixer.SetFloat ("MusicVol",Mathf.Log10(ConstantData.mixerLevel)*20);
    }

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        animator.SetBool("IsOne", true);
        Roboanimator.SetBool("IsOneRobo", true);
        AngryRoboanimator.SetBool("IsOneRobo", true);

        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if (sentences.Count == 0){
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            dialogText.text += letter;
            yield return null;
        }
    }

    public void EndDialog(){
        animator.SetBool("IsOne", false);
        Roboanimator.SetBool("IsOneRobo", false);
        AngryRoboanimator.SetBool("IsOneRobo", false);
        Back.SetActive(false);
        if (ifNextScene == true){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
