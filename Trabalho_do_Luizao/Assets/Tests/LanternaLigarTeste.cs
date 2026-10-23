using NUnit.Framework;
using UnityEngine;
using UnityEditor;

public class LigarLanternaTests
{
    private GameObject objetoLanterna;
    private GameObject luz;
    private GameObject texto;
    private Ligar_Lanterna script;

    [SetUp]
    public void Preparar()
    {
        objetoLanterna = new GameObject("LanternaTest");
        luz = new GameObject("LuzTest");
        texto = new GameObject("TextoTest");

        script = objetoLanterna.AddComponent<Ligar_Lanterna>();

        var serialized = new SerializedObject(script);

        serialized.FindProperty("Luz_Lanterna").objectReferenceValue = luz;
        serialized.FindProperty("Texto").objectReferenceValue = texto;

        serialized.ApplyModifiedProperties();

        luz.SetActive(false);
        texto.SetActive(false);
    }

    [TearDown]
    public void Limpar()
    {
        Object.DestroyImmediate(objetoLanterna);
        Object.DestroyImmediate(luz);
        Object.DestroyImmediate(texto);
    }

    [Test]
    public void LanternaComecaDesligada()
    {
        Assert.IsFalse(luz.activeSelf);
        Assert.IsFalse(texto.activeSelf);
    }

    [Test]
    public void LanternaLigaCorretamente()
    {
        script.AlternarLanterna();

        Assert.IsTrue(luz.activeSelf);
        Assert.IsTrue(texto.activeSelf);
    }

    [Test]
    public void LanternaDesligaCorretamente()
    {
        script.AlternarLanterna();
        script.AlternarLanterna();

        Assert.IsFalse(luz.activeSelf);
        Assert.IsFalse(texto.activeSelf);
    }
}