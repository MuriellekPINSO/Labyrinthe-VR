**Rapport de Projet : Exploration d’un Labyrinthe en Réalité Virtuelle**

---

## **1. Introduction**

### **1.1 Contexte et Objectifs**
Ce projet de **réalité virtuelle (VR)** consiste en l’exploration d’un labyrinthe complexe, où l’utilisateur doit se frayer un chemin vers la sortie en utilisant des indices dissimulés dans l’environnement. Le but est de proposer une immersion réaliste et engageante, tout en exploitant des technologies VR avancées.

### **1.2 Technologies utilisées**
- **Unity** : Moteur de jeu utilisé pour la conception et la mise en œuvre du projet.
- **Blender** : Logiciel utilisé pour la modélisation du labyrinthe.
- **Google VR SDK** : Intégré pour gérer l’affichage et les interactions VR.
- **Mini First Person Controller** : Utilisé pour la gestion des déplacements du joueur.
- **C# (Unity Scripts)** : Pour implémenter les différentes mécaniques de jeu et interactions.
- **Effets audio** : Ajoutés sur des statues 3D, se déclenchant lorsqu'elles entrent dans le champ de vision de l’utilisateur.

---

## **2. Modélisation et Conception du Labyrinthe**

### **2.1 Création du Labyrinthe**
Le labyrinthe a été modélisé sous **Blender**, en prenant soin d’intégrer des chemins variés, des impasses et une sortie bien dissimulée pour rendre l’expérience immersive. Une fois modélisé, il a été exporté et importé dans Unity en tant qu’objet 3D.

### **2.2 Ajout des Indices et Statues**
Des **indices** sont cachés dans l’environnement pour guider le joueur vers la sortie. Ces indices peuvent être des objets interactifs ou des **statues 3D**, auxquelles des **effets audio** ont été ajoutés pour renforcer l’immersion.

### **2.3 Effets Visuels et Sonores**
- **Effets sonores** : Lorsque le joueur s’approche des statues, un effet sonore se déclenche s’ils sont dans son champ de vision.
- **Effets lumineux** : Certains indices bénéficient d’une mise en valeur visuelle pour faciliter leur repérage.

---

## **3. Implémentation du Déplacement en VR**

### **3.1 Google VR SDK**
L’intégration du **Google VR SDK** permet d’utiliser un **casque VR** pour explorer le labyrinthe avec une meilleure immersion.

### **3.2 Mini First Person Controller**
Le **Mini First Person Controller** a été utilisé pour gérer les déplacements du joueur dans l’environnement 3D. Ce composant permet un déplacement fluide avec :
- **Un déplacement en avant basé sur l’orientation de la caméra**.
- **Un saut pour franchir certains obstacles**.
- **Une interaction avec les éléments du décor**.

---

## **4. Développement et Programmation**

### **4.1 Script de Déplacement du Joueur**
Le script **VR_PlayerController.cs** a été écrit en **C#** pour gérer les déplacements du joueur. Il prend en charge :
- La détection de l’orientation de la caméra.
- La gestion de la gravité et des sauts.
- La détection de l’entrée dans le champ de vision des statues.

### **4.2 Gestion des Interactions Audio**
Un script spécifique **audioPlayer.cs** permet de déclencher les effets sonores lorsque les statues entrent dans le champ de vision du joueur.

---

## **5. Résultats et Problèmes Rencontrés**

### **5.1 Résultats Obtenus**
Le projet fonctionne et permet une exploration fluide du labyrinthe en **réalité virtuelle** avec un **casque VR compatible Google VR**. Les indices, effets audio et statues apportent une véritable **dimension immersive** à l’expérience.

### **5.2 Problèmes Techniques et Solutions**
1. **Problème : Warnings liés à des variables non assignées dans les scripts Google VR.**
   - **Solution :** Ajout explicite d’assignations ou suppression des variables inutilisées.

2. **Problème : Erreur CS0116 (Namespace contenant des méthodes directement).**
   - **Solution :** Encapsuler les méthodes dans une classe Unity **MonoBehaviour**.

3. **Problème : Échec de la compilation Unity avec erreur 'Build Failed'.**
   - **Solution :** Vérification des logs d’erreur pour identifier les dépendances manquantes et ajustement des paramètres de build.

---

## **6. Conclusion et Perspectives**

Ce projet a permis d’explorer différentes facettes du développement **VR sous Unity**, en combinant modélisation 3D, interactions utilisateur et gestion du déplacement immersif.

### **Perspectives d’Amélioration**
- **Ajout d’un système de score ou de chronomètre** pour inciter les joueurs à explorer plus efficacement.
- **Intégration de nouveaux effets visuels** (brouillard, lumières dynamiques) pour renforcer l’ambiance.
- **Optimisation des performances** pour améliorer la fluidité sur différentes plateformes VR.

En conclusion, ce projet a permis d’acquérir une bonne compréhension du développement en VR et de l’intégration de **Google VR dans Unity**.

---


