# GitHub Projects i Pull Requests (PR)
En primer lloc, crearem un projecte base al Visual Studio i crearem el seu repositori Git/GitHub:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/base_project.jpg" width="600" height="300">

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/base_project_github.jpg" width="600" height="300">

A continuació, crearem un projecte dins GitHub:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/github_project.jpg"  width="600" height="300">

**Important!** La visibilitat del projecte ha de ser pública.

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/github_project_visibility.jpg"  width="600" height="300">

Un cop creat el projecte, afegim la primera tasca, fent clic al botó "Add item". Indicarem en la finestra el repositori que gestionarà les funcionalitats i marcarem la *template* "blank issue":

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_new_issue.jpg"  width="600" height="300">

Mostrarà una pantalla en la que indicarem el títol de la tasca i la descripció (opcional). En crear-la com a *issue*, li assignarà un número de tasca (precedit de '#'). Això ens permetrà vincular-la amb les versions del repositori. En cas que la tasca es quedi com a "draft", cal convertir-la en "issue", assignant-la al repositori:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/github_projct_draft_to_issue.jpg"  width="200" height="300">

Movem l'issue a la columna "In progress":

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/github_project_inprogress.jpg"  width="600" height="300">

Si revisem el menú superior, veurem que l'issue apareix al repositori, però no el projecte. Cal vincular el projecte al repositori. Des del menú *Projects*, fem clic al botó "Link a project:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/github_project_linktorepository.jpg"  width="600" height="300">

Implementem la funcionalitat i creem una nova branca per a aquesta (branch per feature) des de Visual Studio, fent checkout per a treballar en aquesta:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature.jpg"  width="600" height="300">
<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_branch.jpg"  width="600" height="300">

Un cop implementada la funcionalitat, fem commit i push a la branca. És molt important que al comentari del codi s'afegeixi la notació següent, que permet tancar la tasca del projecte:
```Added input validation. Closes #1 ```

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_commit.jpg"  width="600" height="300">
<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_push.jpg"  width="600" height="300">

En aquest cas, els canvis no es pugen directament a la branca *master* del GitHub (aquesta continua sense canvis) però sí que s'han pujat a la branca *feature*:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_master.jpg">
<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_branch_feature.jpg"  width="600" height="300">

Podem veure que al projecte tampoc es tanca l'issue, ja que aquesta tasca no ha finalitzat:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_project.jpg"  width="600" height="300">

Per tal que s'afegeixi a la branca master, haurem de fer una petició de validació de codi (pull request, PR)
 
<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_pr.jpg"  width="600" height="300">

Si tot és correcte, es validarà la petició,

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_pr_merge.jpg"  width="600" height="300">

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_pr_merge_comment.jpg"  width="600" height="300">

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_pr_merged.jpg"  width="600" height="300">

movent l'issue com a "Done". Ens apareixerà un segon issue, amb el comentari del nostre commit:

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_pr_merged_done.jpg"  width="600" height="300">

Ara sí podem comprovar que s'ha fet el merge amb la branca "master": 

<img src="https://github.com/RaquelAlamanITB/bloc-programacio/blob/main/m05entorns/uf2/_img/project_feature_pr_merged_master.jpg"  width="600" height="300">

De cara a una següent funcionalitat, s'haurà de crear un nou issue i la nova branca per a aquesta nova *feature*.

El projecte i les tasques associades es poden consultar en l'enllaç del [Projecte](https://github.com/users/RaquelAlamanITB/projects/8).
