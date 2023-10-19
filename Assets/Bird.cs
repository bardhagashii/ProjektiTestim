using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    private Vector3 _initalPosition; //pozicioni fillestar
    private bool _birdWasLaunched; //launch i birdit 
    private float _timeSittingAround; //variabla kur osht stuck birdi
    [SerializeField] private float _launchPower = 500; // e krijon ni fushe te re per me caktu shpejtsine ose launchPower ne Unity 

    private void Awake() // metoda Awake ekzekutohet para fillimit te frame-it te pare
    {
        _initalPosition = transform.position; // na duhet me dit initial position sepse duhet me u resetu pastaj pozita
                                              // (transform osht komponent qe i takon Birdit qe mujm mja ndrru poziten scale..)
                                             
    }

    private void Update() //kontrollon per cdo frame dmth krejt frames e thirrin
    {
        GetComponent<LineRenderer>().SetPosition(1, _initalPosition); //kjo osht drejtimi i shigjetes per me gjujt Birdin, merre komponenten LineRenderer 
        GetComponent<LineRenderer>().SetPosition(0, transform.position); //pjesen e indeksimit le 0 kurse pjesen e initialPosisiton merre prej Bird



        if (_birdWasLaunched && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1) // e merr shpejtsine e levizjes, nese Bird u bo launch edhe ka mbet stuck bone reload 
        {
            _timeSittingAround += Time.deltaTime;  //variabla qe llogarit per sa kohe ka nejt ne ate pozite Birdi
                                                   // varet sa frames jemi tu perdor, nese i kemi 4fps jon 1/4=0.25
        }                                           

        if (transform.position.y > 6 || transform.position.y < -6 ||                       
            transform.position.x > 15 || transform.position.x < -15 ||
            _timeSittingAround > 3) {                                     // merri koordinatat x,y nese del Birdi jasht qityne ki me bo reload scene
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);                      //reload scene
        }
    }
        private void OnMouseDown() //ne momentin qe ne e klikojme me maus Birdin ai bohet i kuq,
                                   //dmth shkon te komponentat e sprite renderer edhe e merr ngjyren aktuale e bon te kuqe
        {

            GetComponent<SpriteRenderer>().color = Color.red;
            GetComponent<LineRenderer>().enabled = true;   //ne momentin qe e ki onMouseDown shfaqe line renderer
        }

        private void OnMouseUp() 
        {
            GetComponent<SpriteRenderer>().color = Color.white; // ne momentin qe e hek mausin bohet prap i kuq Birdi
            Vector2 directionToInitialPosition = _initalPosition - transform.position;          // ja cakton edhe drejtimin (direction) = e merr initial position edhe e zbret me transform position
            GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _launchPower); // me shtu force qe ne momentin qe e bojme release me u gjujt Birdi
                                                                                            
            GetComponent<Rigidbody2D>().gravityScale = 1;   // kjo pjese mundson qe me zbrit Birdi n'toke pasi te bojm launch perndryshe kurre s'prek
            _birdWasLaunched = true;

            GetComponent<LineRenderer>().enabled = false; // kur e lshojme mausin nuk shfaqet mo line renderer
    }

        private void OnMouseDrag()  // i merr koordinatat e mausit edhe i reflekton ne loje, dmth na len me leviz Birdin sipas mausit.
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // thirre kameren main edhe thirre metoden ScreenToWorldPoint
            transform.position = new Vector3(newPosition.x, newPosition.y);            // e krijojme objekt te ri ku ja dergojme koordinatat qe na nevojiten
        }

    } 
