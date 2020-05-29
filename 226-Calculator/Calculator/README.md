# Calculator

## Auteur

Nicolas Glassey

---
## Généralité

Il s'agit d'un petit projet permettant aux développeurs juniors de réactiver leurs compétences en C#.

Il est présenté comme exercice de réactivation et permet d'aborder les bases de la POO.

Pour l'utilisateur, il s'agit d'une console qui lui propose de saisir un calcul et lui livre ensuite la réponse.

---
## Etapes de réalisation et intention

Chaque étape correspond à un commit sur la branche master. Vous pouvez ainsi déroulé le projet en vous adaptant au rythme des développeurs juniors.

* **Step00 - Code de départ**
  * Récupérer le code à l'aide de git.
  * Compiler, exécuter et tester le projet.
  * Afficher la valeur des variables (debug).
  * Lire du code produit par un autre développeur.
  * Les régions ?
  * Mot clé "static"
  * Mot clé "operator"
   
* **Step01 - Décentralisation de la couche métier**
  * Ajout d'un nouveau projet de type librairie.
  * Référencer un projet.
  * Namespace / Using ?
  * Ecrire sa première classe.
  * Instancier la classe.
  * Appeler la méthode d'une classe.
   
* **Step02 - Enrichissement fonctionnel (plus d'opérateurs)**
  * Coder une structure conditionnelle en C#
  * Tester son programme via la console
  * Ajouter des méthodes à une classe
  * Boucle infinie en C#

* **Step03 - Refactorisation du programme principal**
  * Simplifier le code du main et décomposer en méthode
  * Coder des méthodes
* **Step04 - Ajout de la classe "Math Request"**
  * La saisie de l'utilisateur pourrait-être un objet...
* **Step05 - Introduction au TDD**
  * Coder la classe "Math request" en partant des tests
  * Utiliser le Framework de test de Visual Studio
* **Step06 - Intégrer la classe "Math Request**
  * Remplacer le trio "op1, op, op2" par le type "Math Request"
  * Prouver la non-regression à l'aide des tests
  * Référencer la classe "Math Request" 
* **Step07 - Gestion des exceptions**
  * Utiliser des exceptions existantes (Division by zero Exception, Format Exception)
  * Créer sa propre exception (opérateur impossible)
  * Réécrire le message d'erreur pour aider l'utilisateur

A chaque étape, les diagrammes de classes et séquences sont disponibles pour familiariser les développeurs juniors.

Le travail de documentation est également exercé dès le début du projet.

---
## Structure du dépôt

La structure présentée ici est la structure qui sera mise en place, étape par étape. Il est possible, en début de projet, que la structure soit un peu différente.

* Dépôt
   * [docs]
       * documentation de conception (diagrammes de classes, séquences produit avec Astha)
       * documentation auto-générée (comprend un fichier de configuration pour doxygène)
   * [src]
       * [model] la couche métier centralisant la logique de l'application
       * [view]  la couche qui permettra à l'utilisateur d'intéragir avec l'application

   * .gitignore est pré-configuré pour visual studio 2019

---
## Installation

* Récupérer le dépôt (git clone)
* Compiler le projet
* Exécuter
* Tester via la console
* Lancer les tests (n'est pas disponible au début du projet)

---
## License
[Licence](Licence.md)