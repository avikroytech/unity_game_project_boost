using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] AudioClip success;
    [SerializeField] AudioClip crash;
    [SerializeField] ParticleSystem successParticles;
    [SerializeField] ParticleSystem crashParticles;

    AudioSource audioSource;
    BoxCollider bCollider;
    // These are my flags
    bool isTransitioning = false;
    bool collisionDisabled = false;

    void Start() {
        audioSource = GetComponent<AudioSource>();
        bCollider = GetComponent<BoxCollider>();
    }

    void Update() {
        DebugMode();
    }
    
    //This is a collision handler 
    void OnCollisionEnter(Collision other) {

        if (isTransitioning || collisionDisabled) { return; }

        switch (other.gameObject.tag) {
            case "Friendly":
                Debug.Log("This is friendly");
                break;
            case "Finish":
                SucessSequence(); 
                break;
            default:
                StartCrashSequence();
                break;
        }
    }
    
    void DebugMode() {
        if (Input.GetKeyDown(KeyCode.L)) {
            LoadNextLevel();
        }

        else if (Input.GetKeyDown(KeyCode.C)) {
            collisionDisabled = !collisionDisabled;
        }
    }

    void SucessSequence() {
        isTransitioning = true;
        playActions(success, successParticles);
        GetComponent<Movement>().enabled = false;
        Invoke("LoadNextLevel", levelLoadDelay);
    }

    void StartCrashSequence()
    {
        isTransitioning = true;
        playActions(crash, crashParticles);
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);
    }

    void playActions(AudioClip audio, ParticleSystem particles)
    {
        audioSource.Stop();
        audioSource.PlayOneShot(audio);
        particles.Play();
    }

    void ReloadLevel() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void LoadNextLevel() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings) {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
