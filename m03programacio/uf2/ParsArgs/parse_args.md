# Pas d'arguments dins la funció principal (Main)
El mètode principal Main pot rebre paràmetres (args). Aquests arguments s'emmagatzemen en un array de tipus string, per tant, el podem recórrer com qualsevol array de strings (for, foreach).

```c#
public static void ParseArgs(string[] args)
{
    foreach (string arg in args)
    {
        Console.WriteLine(arg);
    }
}
```

Per tal d'executar el nostre programa enviant arguments, podem fer-ho des del Visual Studio o executant l'executable des de la consola:
1. Des de Visual Studio: Fer botó dret sobre **Projecte**->Properties. Dins l'apartat "Debug", fer clic a l'enllaç "Open debug launch profiles UI". En la secció "Command line arguments" indicarem els arguments a parsejar.

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m03programacio/uf2/ParsArgs/img/parseargs_vs.jpg" >

2. Des de la consola: situats dins la carpeta de l'executable, obrim la cmd i escribim el nom de l'executable, seguit dels arguments a parsejar:
```batch
C:\Users\csharp\ParseArgs\bin\Debug\net7.0>ParseArgs.exe 3 4
```

*Cal tenir en compte que els arguments són rebuts com a strings, per tant, si volem realitzar operacions aritmètiques amb ells, s'hauran de convertir primer*.

En el següent [enllaç](https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m03programacio/uf2/ParsArgs/ParseArgs.cs) hi ha diversos exemples d'ús.
