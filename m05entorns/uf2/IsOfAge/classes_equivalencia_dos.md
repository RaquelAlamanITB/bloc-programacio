# Proves funcionals. Classes d’equivalència i valors límit II

Es volen definir les proves de caixa negra per a un mètode que retorna un valor booleà indicant si una persona és major d'edat:

Les classes d'equivalència i valors límit es mostren a la taula següent:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/IsOfAge/img/taula_classes.jpg">

- En color verd es marca una classe d'equivalència que és vàlida (des dels 18 anys cap endavant) i retornen un valor cert (T) en invocar el mètode.
- En color groc es marca una classe d'equivalència que és vàlida (des dels 0 fins als 18 anys, no inclòs) i retornen un valor fals (F) en invocar el mètode.
- En color vermell es marca una classe d'equivalència que no és vàlida que inclou tots els valors des de menys infinit fins a 0 (aquells valors que no tenen sentit per al mètode).

Un cop disposem d'aquesta informació, podem dissenyar les proves unitàries, escollint com a valors per a dur-les a terme els valors límit (ja que són els que generen més conflicte). Dissenyem la taula numerant cada prova, on cada cas correspondrà a un dels valors límit. 

**Important**: tenint en compte que no es pot provar un valor infinit, se seleccionen els valors -100 i 100 com a aproximacions.
 
<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/IsOfAge/img/taula_proves.jpg">

Definits els casos, implementem les proves unitàries corresponent a cada cas de la taula:

```C#
[TestMethod]
public void IsOfAge_LowestNoValidLimit_ReturnsError()
{
    //Arrange
    int age = -100;
    bool result;

    //Act
    result = Validate.IsOfAge(age);

    //Assert
    Assert.IsFalse(result, "Edat no pot ser un valor negatiu"); //si l'asserció donés T, mostraria el missatge d'error
}
[TestMethod]
public void IsOfAge_HighestNoValidLimit_ReturnsError()
{
    //Arrange
    int age = -1;
    bool result;

    //Act
    result = Validate.IsOfAge(age);

    //Assert
    Assert.IsFalse(result, "Edat no pot ser un valor negatiu"); //si l'asserció donés T, mostraria el missatge d'error
}
[TestMethod]
public void IsOfAge_LowestLimit_ReturnsFalse() {
    //Arrange
    int age = 0;
    bool result;

    //Act
    result = Validate.IsOfAge(age);

    //Assert
    Assert.IsFalse(result);
}
[TestMethod]
public void IsOfAge_HighestLimit_ReturnsFalse()
{
    //Arrange
    int age = 17;
    bool result;

    //Act
    result = Validate.IsOfAge(age);

    //Assert
    Assert.IsFalse(result);
}
[TestMethod]
public void IsOfAge_LowestLimit_Returnstrue()
{
    //Arrange
    int age = 18;
    bool result;

    //Act
    result = Validate.IsOfAge(age);

    //Assert
    Assert.IsTrue(result);
}
[TestMethod]
public void IsOfAge_HighestLimit_Returnstrue()
{
    //Arrange
    int age = 100;
    bool result;

    //Act
    result = Validate.IsOfAge(age);

    //Assert
    Assert.IsTrue(result);
}
```
