# Proves de caixa negra. Classes d’equivalència

Es volen definir les proves de caixa negra per a una funció que retorna el nom del mes a partir del seu valor numèric (correspon a les proves de la implementació del mètode [NomDelMes](https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m03programacio/uf2/Basic_Methods/Program.cs)):

```
Console.WriteLine(NomDelMes(4));

public static string NomDelMes(int mes)
{
    //switch expression
    string month = mes switch
    {
        1 => "Gener",
        2 => "Febrer",
        3 => "Març",
        4 => "Abril",
        5 => "Maig",
        6 => "Juny",
        7 => "Juliol",
        8 => "Agost",
        9 => "Setembre",
        10 => "Octubre",
        11 => "Novembre",
        12 => "Desembre",
        _ => "Valor invàlid"
    };
    return month;
}
```

#### Classes d'equivalència ####
Es defineixen 3 classes d'equivalència, on es determina a cadascuna si els seus valors són vàlids o invàlids:

* Valors vàlids: 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12 
* Valors invàlids: ..., -02, -01, 00
* Valors invàlids: 13, 14, 15, ... 

#### Valors límit ####

Límit Inferior - Mes 1 =>
Entrada: 1.
Resultat esperat: "Gener".

Límit Superior - Mes 12 =>
Entrada: 12.
Resultat esperat: "Desembre".

Valor Invàlid Inferior - Mes 0 =>
Entrada: 0.
Resultat esperat: "Valor invàlid".

Valor Invàlid Superior - Mes 13 =>
Entrada: 13.
Resultat esperat: "Valor invàlid".
