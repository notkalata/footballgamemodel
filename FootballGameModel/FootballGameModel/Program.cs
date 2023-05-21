using System;
using System.Collections.Generic;

namespace FootballGameModel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализиране на треньорите.

            Coach chelseaCoach = new Coach("Thomas Tuchel", 49);
            Coach liverpoolCoach = new Coach("Jurgen Norbert Klopp", 55);

            // Инициализиране на играчите.

            FootballPlayer chelseaPlayer1 = new Goalkeeper("Marcus Betinelli", 30, 13, 1.81);
            FootballPlayer chelseaPlayer2 = new Midfield("Ivan Morizki", 29, 10, 1.85);
            FootballPlayer chelseaPlayer3 = new Midfield("George Petrovski", 28, 6, 1.76);
            FootballPlayer chelseaPlayer4 = new Striker("Martin Hristov", 30, 12, 1.85);
            FootballPlayer chelseaPlayer5 = new Midfield("Antonio Verstappen", 29, 21, 1.84);
            FootballPlayer chelseaPlayer6 = new Defender("Atanas Kraevski", 32, 6, 1.76);
            FootballPlayer chelseaPlayer7 = new Striker("Albert Atanasov", 22, 8, 1.8);
            FootballPlayer chelseaPlayer8 = new Midfield("Yordan Vaklinov", 25, 9, 1.85);
            FootballPlayer chelseaPlayer9 = new Defender("Petar Anestev", 32, 1, 1.76);
            FootballPlayer chelseaPlayer10 = new Defender("Nestor Kehayov", 24, 15, 1.74);
            FootballPlayer chelseaPlayer11 = new Defender("Kiril Andonov", 25, 29, 1.80);

            FootballPlayer liverpoolPlayer1 = new Goalkeeper("Roberto Triksta", 30, 13, 1.81);
            FootballPlayer liverpoolPlayer2 = new Midfield("Ivan Andreev", 29, 10, 1.85);
            FootballPlayer liverpoolPlayer3 = new Midfield("Crestin Hrstuv", 28, 6, 1.76);
            FootballPlayer liverpoolPlayer4 = new Defender("Aleksandar Quebec", 30, 12, 1.85);
            FootballPlayer liverpoolPlayer5 = new Midfield("Max Drink", 29, 21, 1.84);
            FootballPlayer liverpoolPlayer6 = new Defender("Ben Dover", 32, 6, 1.76);
            FootballPlayer liverpoolPlayer7 = new Defender("Alberto Perinda", 22, 8, 1.8);
            FootballPlayer liverpoolPlayer8 = new Striker("Mario Broski", 25, 9, 1.85);
            FootballPlayer liverpoolPlayer9 = new Striker("Boris Atanasov", 32, 1, 1.76);
            FootballPlayer liverpoolPlayer10  = new Defender("Hristos Tsitsipas", 24, 15, 1.74);
            FootballPlayer liverpoolPlayer11 = new Striker("Artem Elenin", 25, 29, 1.80);

            // Създаване на списъци, съдържащи играчите на двата отбора.

            List<FootballPlayer> chelseaSelection = new List<FootballPlayer>();
            chelseaSelection.Add(chelseaPlayer1);
            chelseaSelection.Add(chelseaPlayer2);
            chelseaSelection.Add(chelseaPlayer3);
            chelseaSelection.Add(chelseaPlayer4);
            chelseaSelection.Add(chelseaPlayer5);
            chelseaSelection.Add(chelseaPlayer6);
            chelseaSelection.Add(chelseaPlayer7);
            chelseaSelection.Add(chelseaPlayer8);
            chelseaSelection.Add(chelseaPlayer9);
            chelseaSelection.Add(chelseaPlayer10);
            chelseaSelection.Add(chelseaPlayer11);

            List<FootballPlayer> liverpoolSelection = new List<FootballPlayer>();
            liverpoolSelection.Add(liverpoolPlayer1);
            liverpoolSelection.Add(liverpoolPlayer2);
            liverpoolSelection.Add(liverpoolPlayer3);
            liverpoolSelection.Add(liverpoolPlayer4);
            liverpoolSelection.Add(liverpoolPlayer5);
            liverpoolSelection.Add(liverpoolPlayer6);
            liverpoolSelection.Add(liverpoolPlayer7);
            liverpoolSelection.Add(liverpoolPlayer8);
            liverpoolSelection.Add(liverpoolPlayer9);
            liverpoolSelection.Add(liverpoolPlayer10);
            liverpoolSelection.Add(liverpoolPlayer11);

            // Инициализиране на двата отбора.

            Team chelsea = new Team(chelseaCoach, chelseaSelection);
            Team liverpool = new Team(liverpoolCoach, liverpoolSelection);

            // Инициализиране на съдия, помощник съдии, списък с помощник съдии за играта.

            Referee gameReferee = new Referee("Ivan Atanasov", 43);

            Referee assistantReferee1 = new Referee("Kiril Petrov", 51);
            Referee assistantReferee2 = new Referee("Mihail Petkov", 40);

            List<Referee> assistantReferees = new List<Referee>();
            assistantReferees.Add(assistantReferee1);
            assistantReferees.Add(assistantReferee2);

            // Инициализиране на игра, използвайки всички по-горни елементи.

            Game game = new Game(chelsea, liverpool, gameReferee, assistantReferees);

            // Добавяне на голове към играта.

            game.AddGoal(10, liverpoolPlayer11);
            game.AddGoal(43, chelseaPlayer4);
            game.AddGoal(71, chelseaPlayer9);

            // Извеждане на краен резултат и победител(GameResult и Winner са на едно).

            game.GetGameResult();
        }
    }
}
