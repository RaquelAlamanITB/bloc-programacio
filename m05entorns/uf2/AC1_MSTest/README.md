# AC1. Unit testing i detecció de proves

Els passos a seguir per a automatitzar una prova unitària d'una solució ja existent. Farem servir MS Test, el marc de treball de proves unitàries creat per Microsoft. És popular perquè és fàcil d'usar i està integrat amb Visual Studio.

**1. Crear un projecte de test unitari**

Dins la finestra "Solution Explorer", fem botó dret sobre la solució que es vol testejar. En el menú contextual, cliquem sobre "Add" -> "New Project". 
Busquem el projecte de tipus "MSTest" i crearem el projecte de test.

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/add_test_project.jpg" width="400" height="300">

**2. Afegir la dependència al projecte**

Des de la finestra "Solution Explorer" -> botó dret sobre el projecte Test -> "Add" -> "Project Reference". 
<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/add_reference_test.png" width="400" height="300">

Fem clic al check del projecte que apareix a la finestra i cliquem al botó "Ok".

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_reference.jpg" width="400" height="300">

**3. Implementar els mètodes que comprovaran les asercions**

En el codi font del projecte de test, es defineixen els mètodes que verificaran, mitjançant les asercions i seguint el patró AAA, els mètodes del projecte principal. **Molt important!** Si la classe principal (la que conté els mètodes que volem validar) no és pública (no conté la paraula reservada _public_) abans de la paraula reservada "class", no podrem accedir als seus mètodes ni, per tant, valodar-los.

```java
[TestClass]
public class BasicMathTests
{
    [TestMethod]
    public void ComparePow_Return_True()
    {
        // Arrange
        int baseNum = 2, exp = 3;

        // Act
        int result = Validate.PowNumber(baseNum, exp);

        // Assert
        Assert.AreEqual(8, result);
    }
}
```
Si es defineix més d'un test, cada mètode ha d'anar precedit de l'atribut *[TestMethod]*.

**4. Implementar els mètodes que comprovaran les asercions**

Des del menú superior del IDE, fer clic a l'opció "Test -> Run all Tests". El resultat del test unitari es mostrarà en la finestra "Test Explorer" (tant si és vàlid com si ha donat error), així com els mètodes implementats. Per exemple:
<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/test_result.jpg" width="400" height="300">

**5. Anàlisi de valors límit i errors típics**

Hi ha tècniques que serveixen per seleccionar millor les classes d’equivalència. Una és l’anàlisi dels valors límit. Els casos de prova que se centren en els valors límit produeixen un millor resultat per a la detecció de defectes. D’aquesta manera, en escollir l’element representatiu de la classe d’equivalència, en lloc d’agafar-ne un qualsevol, s’escullen els valors al límit i, si es considera oportú, un valor intermedi. A més a més, també s’intenta que els valors a l’entrada provoquin valors límit als resultats.

A l’hora d’escollir els representants de cada classe se seguiran les recomanacions següents:
* En els rangs de valors, agafar els extrems del rang i el valor intermedi.
* Si s’especifiquen una sèrie de valors, agafar el superior, l’inferior, l’anterior a l’inferior i el posterior al superior.
* Si el resultat es mou en un determinat rang, hem d’escollir dades a l’entrada per provocar les sortides mínima, màxima i un valor intermedi.
* Si el programa tria una llista o taula, agafar l’element primer, l’últim i l’intermedi.

També es pot aprofitar l’experiència prèvia. Hi ha una sèrie d’errors que es repeteixen molt en els programes, i podria ser una bona estratègia utilitzar casos de prova que se centrin a buscar aquests errors. D’aquesta manera, es millorarà l’elecció dels representants de les classes d’equivalència:
* El valor zero acostuma a provocar errors. Per exemple, una divisió per zero bloqueja el programa. Si es té la possibilitat d’introduir zeros a l’entrada, s’ha d’escollir en els casos de prova.
* Quan s’ha d’introduir una llista de valors, caldrà centrar-se en la possibilitat de no introduir cap valor, o introduir-ne un.
* S’ha de pensar que l’usuari pot introduir entrades que no són normals, per això és recomanable posar-se en el pitjor cas.
* Els desbordaments de memòria són habituals, per això s’ha de provar d’introduir valors tan grans com sigui possible.


**Documentació oficial:** https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
