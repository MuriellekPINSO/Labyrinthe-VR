**Rapport de TP : Exploration d’un Labyrinthe en Réalité Virtuelle**

---

## 1. Introduction

Dans le cadre de ce travail pratique, nous avons développé une application de réalité virtuelle permettant aux utilisateurs d'explorer un labyrinthe complexe. L'objectif principal est de trouver la sortie en utilisant des indices dissimulés dans l'environnement, tout en respectant un temps imparti. Ce projet a été réalisé à l'aide de **Unity**, **Blender**, **Google VR**, et **Mini First Person Controller**.

---

## 2. Objectifs du Projet

L’application vise à :
- Offrir une expérience immersive de navigation dans un labyrinthe en réalité virtuelle.
- Guider l'utilisateur vers la sortie grâce à des indices sonores et visuels.
- Intégrer un chronomètre pour ajouter un défi temporel.
- Proposer une rejouabilité en cas d’échec ou de succès.

---

## 3. Outils et Technologies Utilisés

### 3.1. Unity
Nous avons utilisé **Unity** comme moteur de jeu pour la création de l’environnement interactif et la gestion des scripts.

### 3.2. Blender
Le labyrinthe a été **modélisé sous Blender** avant d’être importé dans Unity. Ce processus a permis de concevoir une structure optimisée et réaliste.

### 3.3. Google VR
Google VR a été intégré pour permettre une expérience immersive en réalité virtuelle, avec la gestion du **mouvement de la tête et de l’interaction utilisateur**.

### 3.4. Mini First Person Controller
Pour le déplacement du joueur, nous avons utilisé **Mini First Person Controller**, permettant un contrôle fluide et intuitif.

---

## 4. Développement du Projet

### 4.1. Modélisation du Labyrinthe
- Le labyrinthe a été conçu avec Blender en prenant en compte des **chemins sinueux, des impasses et des zones de repère**.
- Il a ensuite été importé dans Unity avec une texture et des lumières adaptées pour une meilleure immersion.

### 4.2. Déplacement du Joueur
- L’utilisateur se déplace grâce au **Mini First Person Controller**.
- La direction du mouvement est basée sur l’orientation de la caméra principale.
- Une physique adaptée a été appliquée pour assurer un déplacement réaliste.

### 4.3. Interaction avec les Statues 3D
- Des **statues 3D** ont été placées à des endroits stratégiques du labyrinthe.
- Lorsqu’une statue entre dans le champ de vision du joueur, un **effet sonore** est déclenché pour donner un indice.
- Ces indices sonores aident l’utilisateur à s’orienter vers la sortie.

### 4.4. Gestion du Minuteur
- Un **compteur de temps** est affiché à l’écran dès le début de l’exploration.
- Si le joueur **ne trouve pas la sortie avant la fin du temps imparti**, un message de **Game Over** apparaît et le joueur est redirigé au début du labyrinthe.
- Si le joueur réussit à atteindre la sortie dans le temps imparti, un **message de victoire** s’affiche et il est également redirigé à l’entrée pour une nouvelle partie.

---

## 5. Résultats et Tests

Des tests ont été effectués pour s’assurer du bon fonctionnement des éléments suivants :
- **Navigation fluide** dans le labyrinthe sans collision anormale.
- **Détection correcte des statues** et déclenchement des effets sonores au bon moment.
- **Affichage du chronomètre** et gestion des conditions de victoire et d’échec.
- **Compatibilité avec Google VR** pour assurer une immersion totale.

---

## 6. Améliorations Possibles

- Ajouter un **système de score** basé sur le temps restant.
- Intégrer une **génération procédurale du labyrinthe** pour plus de rejouabilité.
- Introduire **plusieurs niveaux de difficulté** avec des labyrinthes plus complexes.
- Améliorer les **effets sonores et visuels** pour renforcer l’expérience immersive.

---

## 7. Conclusion

Ce projet de TP nous a permis d’explorer plusieurs aspects du **développement en réalité virtuelle**, de la **modélisation 3D** à l’**intégration dans Unity** en passant par l’utilisation de **Google VR**. Grâce aux interactions mises en place et au défi du chronomètre, l’expérience utilisateur est engageante et immersive.

Ce TP a également mis en lumière l’importance des détails techniques dans la **conception d’un environnement interactif** et les défis liés à l’optimisation d’une application VR.

---


