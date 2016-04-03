using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour
{

	// Domyślna wartość jest równa 5, ale nie ma żadnej przeszkody aby zmienić tą wartość w edytorze przy pomocy inspektora
	public float speed = 5f;

	/*[SerializeField] attrybut SerializeField pozwoli Unity na 
	 * wyświetlenie zmiennej w inspectorze, dzięki czemu można 
	 * ją ręcznie przypisać z poziomu edytora. My jednak użyjemy
	 * metody GetComponenet() z MonoBehaviour aby zrobić to z poziomu kodu
	 */
	private Transform transform;

	// Ta funkcja wykonuje się tylko przy starcie gry
	// Use this for initialization
	void Start ()
	{
		transform = GetComponent<Transform>();
	}

	// Ta funkcja jest wywoływana co klatkę
	// Update is called once per frame
	void Update () 
	{
		/* Pobieranie wartości z klawiszy sterowania przypisanych do osi 
		 * "Horizontal" w edytorze. Można je zmienić w Edit > Project Settings > Input 
		 */
		float axisX = Input.GetAxis("Horizontal");

		/* Modyfikacja pozycji x poprzez dodanie iloczynu:
		 * speed - prędkość, którą wcześniej zadeklarowaliśmy i ustawiliśmy w inspektorze;
		 * Time.deltaTime - jest to czas pomiędzy jedną klatką a drugą. Dzięki niej możemy "upłynnić" ruch obiektu;
		 * axisX - wartość, którą pobieramy kilka linijek wcześniej - 0 oznacza lewy klawisz,
		   1 oznacza prawy klawisz (strzałki)
		 */
		transform.position = new Vector3(transform.position.x + speed * Time.deltaTime * axisX, transform.position.y);
	}

	// Ta funkcja jest wywoływana gdy obiekt wejdzie w inny collider, który ma zaznaczone isTrigger
	void OnTriggerEnter()
	{
		Debug.Log("Trigger Detected!");
	}
}
