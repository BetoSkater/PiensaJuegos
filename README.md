# PiensaJuegos

## Keywords
- XamarinForms
- .Net
- Realm
- MVVM Model
- iOS
- Android
 
## Introduction
**PiensaJuegos** is a simple relaxing memory games App. The main game is **PasaVocablo** which is a "guess the word" based game. A letter and a hint (the meaning of the word) are given to the player. The player can asnwer the question or pass. In both cases, the player will be given a new word to guess following the alphabet order. The game ends whenever all the words are anwered or when the countdown reaches zero.

## Why did I make this App?
I was a student in a developer course for unemployed people. We had to make a project in less than seven days. I wanted to create a simple app with three main objetives in mind. The first one, to use the MVVM model. The second one,to use good practices(clean code, good organization of the code and tools and so on) and the last one, to focus in the logic aspect. While I was thinking about wich could fit all of this, i recalled that when I was a kid, I used to watch a TV contest called "The Alphabet Game" and suddenly I come by with the idea of how all fitted perfectly.
 
 </br>

## Technologies
**PiensaJuegos** has been made using Xamarin.Forms, which means that can be used both in Android and iOS. So the main languaje is .Net (#C). About the database, **PiensaJuegos** only have a local object oriented database. Dou to the app being able to be ran in Andorid and iOS, the choosen database has been Realm. 
In order to fully separate the logic from the view, the app is structured following the MVVM data model. 

## Functionality 
- **Difficulty selection**:</br>
There's a dificulty selector that allows the player to choose  the game difficulty. This selector has been made binding a slider with a label and has three states "<i>Begginer</i>", "<i>Normal</i>" or "<i>Expert</i>". Depending on the slider's value, the game timer will be set to infinite, 999 seconds (~17 min) or 5 min respectivily.

<p align="center">
  <img src="./seleccion.gif" alt="seleccion" height="720">
</p>



- **Game Loop**:
When the game stars, 27 random number are generated, those are needed to create the array that contains a question object for each letter. A single object has a letter, a question, an answer, and a three states that helps to know if a question has not been answered, another one tracks if the given answer is correct and the last one tracks if the given answer is false. In order to help the user track the state of the game, a "letters grid" has beem added. The current question displays an orange backgroud in the related letter cell in the grid. When the user press the button "<i>PASOVOCABLO</i>" (pass word), the question displayed is "skipped", so it remains unaswered (blue background). Once the user pass or answer the last question and as long as theres time remaining it loops, showing again the unaswered questions. A correct answer sets the letter's cell background to green and a wrong answer, sets it to red.

<p align="center">
  <img src="./bucle.gif" alt="bucle" height="720">
</p>



- **Correct answer**:
Example of input written as the object correct answer field

<p align="center">
 <img src="./correcto.gif" alt="correcto" height="720">
</p>


This is not the only way to answer correctly a question. A memory game is just a game, is not an exam so in  order to make it fair and relaxing, the user can input the answers in diferent ways. In order to acchieve that, "System.Globalization" has been used in the comparison. This mean that a user can input the answer in lower case, upper case, mixed case, using accents and so on. Examples of words that are accepted as correct for the same word: "Ceja", "CEJA", "ceja", "CeJa", "Cèjá" ...

<p align="center">
 <img src="./globalization.gif" alt="globalization" height="720">
</p>


- **Wrong answer**:
<p align="center">
 <img src="./error.gif" alt="error" height="720">
</p>


- **End Game**:
The game ends whenever the user answer all the questions or when the timer reaches zero. At this moment, the score is calculated. If it is among the top 10, an alert dialog with a textbox is shown, in which the user can input a text, like a name or nickname. Afterwards the top 10 score view is shown. If the score is not among the top 10, an average alerdialog is show and then, the top 10 scores.

<p align="center">
 <img src="./puntuaciones.gif" alt="puntuaciones" height="720">
</p>


