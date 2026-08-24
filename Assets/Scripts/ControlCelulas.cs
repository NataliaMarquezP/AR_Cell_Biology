using UnityEngine;

public class ControlCelulas : MonoBehaviour
{
	public GameObject celulaAnimal;
	public GameObject celulaVegetal;
	public GameObject mitocondria;
	public GameObject golgi;
	public GameObject reticulo;

	public void MostrarAnimal()
	{
		OcultarTodo();
		celulaAnimal.SetActive(true);
	}

	public void MostrarVegetal()
	{
		OcultarTodo();
		celulaVegetal.SetActive(true);
	}

	public void MostrarMitocondria()
	{
		OcultarTodo();
		mitocondria.SetActive(true);
	}

	public void MostrarGolgi()
	{
		OcultarTodo();
		golgi.SetActive(true);
	}

	public void MostrarReticulo()
	{
		OcultarTodo();
		reticulo.SetActive(true);
	}

	void OcultarTodo()
	{
		celulaAnimal.SetActive(false);
		celulaVegetal.SetActive(false);
		mitocondria.SetActive(false);
		golgi.SetActive(false);
		reticulo.SetActive(false);
	}
}