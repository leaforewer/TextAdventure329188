using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States //BIJ HIER DE '1' EN '2' NUMMERS BEPALEN DE SITUATIE MET NOTIFICATIE OF ZONDER NOTIFICATIE
    {
        mainmenu,
        start,
        verhaal,
        verderverhaal,
        meldingen,
        meldnee,
        meldja,
        informatiecomputer1,
        informatiecomputer2,
        hackrequest1,
        hackrequest2,
        hackja1,
        hackja2,
        meldingbitcoin1, //wifi suggestion here
        meldingbitcoin2, //gaat naar swat
        wifija,
        wifinee,
        swats,
        swatsend,
        requests1,
        requests2,
        deepweb1,
        deepweb2,
        deepwebsituatie,
        quit1,
        quit2,
        quitja1,
        quitja2,
    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Last Work");
        Terminal.WriteLine("This is a Text-Based game and you must   ensure that you make good choices.");
        Terminal.WriteLine("Every decision you make can change your destiny, be careful.");
        Terminal.WriteLine("                                       ");
        Terminal.WriteLine("Type start to begin");
        currentState = States.mainmenu;
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.mainmenu:
                if (input == "start")
                {
                    Startverhaal();
                }

                break;
            //verhaal
            case States.verhaal:
                if (input == "verder")
                {
                    Verderverhaal();
                }

                break;
            case States.verderverhaal:
                if (input == "notification")
                {
                    Meldingen();
                }

                break;
            //Meldingen
            case States.meldingen:

                if (input == "1")
                {
                    Meldja();
                }

                else if (input == "2")
                {
                    Meldnee();
                }

                break;

            //meld ja
            case States.meldja:

                if (input == "info.cmp")
                {
                    Informatiecomputer1();
                }

                break;

            //meld nee
            case States.meldnee:

                if (input == "info.cmp")
                {
                    Informatiecomputer2();
                }

                break;

            //Hackrequest with notifocation
            case States.informatiecomputer1:
                if (input == "continue")
                {
                    Hacrequest1();
                }

                break;
            //Hackrequest with no notification
            case States.informatiecomputer2:
                if (input == "continue")
                {
                    Hacrequest2();
                }

                break;

            //Hackrequest noti
            case States.hackrequest1:
                if (input == "yes")
                {
                    Hackja1();
                }
                else if (input == "no")
                {
                    Requests1();
                }

                break;
            //Hackrequest no noti
            case States.hackrequest2:
                if (input == "yes")
                {
                    Hackja2();
                }
                else if (input == "no")
                {
                    Requests2();
                }

                break;
            //Hackja
            case States.hackja1:
                if (input == "dascoin")
                {
                    Meldingbitcoin1();
                }

                break;
            //Noti van wifi veranderen
            case States.meldingbitcoin1:
                if (input == "yes")
                {
                    Wifichange();
                }
                else if (input == "no")
                {
                    Wifinochange();
                }

                break;
            //Request menu
            case States.wifija:
                if (input == "request")
                {
                    Requests1();
                }

                break;
            //gelinkd naar de eind van fbi
            case States.wifinee:
                if (input == "request")
                {
                    Swats();
                }

                break;
            case States.hackja2:
                if (input == "dascoin")
                {
                    Meldingbitcoin2();
                }

                break;
            case States.meldingbitcoin2:

                if (input == "request")
                {
                    Swats();
                }

                break;
            case States.swats:
                if (input == "silence")
                {
                    Swatsend();
                }

                break;
            case States.swatsend:
                if (input == "mainmenu")
                {
                    ShowMainMenu();
                }

                break;

            //Hacknee with noti
            case States.requests1:
                if (input == "Deepweb")
                {
                    Deepweb1();
                }
                else if (input == "Hack")
                {
                    Hacrequest1();
                }
                else if (input == "Quit")
                {
                    Quit1();
                }

                break;

            //Hacknee with no noti
            case States.requests2:
                if (input == "Deepweb")
                {
                    Deepweb2();
                }
                else if (input == "Hack")
                {
                    Hacrequest2();
                }
                else if (input == "Quit")
                {
                    Quit2();
                }

                break;

            //Hier wil ik dat player in zelfde nummer blijft 1 of 2. Ook in quit section.
            case States.quit1:
                if (input == "yes")
                {
                    Quitja1();
                }
                else if (input == "no")
                {
                    Requests1();
                }

                break;
            case States.quit2:
                if (input == "yes")
                {
                    Quitja2();
                }
                else if (input == "no")
                {
                    Requests2();
                }

                break;
            case States.quitja1:
                if (input == "mainmenu")
                {
                    ShowMainMenu();
                }

                break;
                case States.quitja2:
                    if (input == "mainmenu")
                    {
                        ShowMainMenu();
                    }

                    break;
        }
    }


    void Startverhaal()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("It's Friday night, and it's the   last hour of your work");
        Terminal.WriteLine("You are happy that you go home after a hour and enjoy chilling, playing games   and more!");
        Terminal.WriteLine("But you hear a noise in a room that you never entered.");
        Terminal.WriteLine("                                        ");
        Terminal.WriteLine("Type 'verder' to continue ..");
        currentState = States.verhaal;
    }

    void Verderverhaal()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You go to the room and you see that the computer is on");
        Terminal.WriteLine("You sit in front of the computer and you see something happen.");
        Terminal.WriteLine("                                           ");
        Terminal.WriteLine("Oh, it was just a notification, type   'notification' to see notification.");
        currentState = States.verderverhaal;
    }

    void Meldingen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You receive a notification to    always turn on the computer's notification.");
        Terminal.WriteLine("Do you want to do this?");
        Terminal.WriteLine("                                         ");
        Terminal.WriteLine("Type '1' to accept or type '2' to not  accept");
        currentState = States.meldingen;
    }

    void Meldja()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Notifications are now on.");
        Terminal.WriteLine("Hello, it's Floeran. I am the best capable computer ever in this computer hell.");
        Terminal.WriteLine("Well, If you want more information    about me,");
        Terminal.WriteLine("Type 'info.cmp' to get information.");
        currentState = States.meldja;
    }

    void Meldnee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello, it's Floeran. I am the best capable computer ever in this computer hell.");
        Terminal.WriteLine("Well, If you want more information    about me,");
        Terminal.WriteLine("Type 'info.cmp' to get information.");
        currentState = States.meldnee;
    }

    void Informatiecomputer1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Information:");
        Terminal.WriteLine(" Made in Germany" +
                           "                    " +
                           "                     " +
                           " Last log : 18/09/1890" +
                           "                " +
                           "                       " +
                           " Specification:" +
                           "                     " +
                           "                     " +
                           " Illegal money transfer" +
                           "                 " +
                           " Access to the Deepweb" +
                           "                 " +
                           "                         " +
                           "Type 'continue' to go further");
        currentState = States.informatiecomputer1;
    }

    void Informatiecomputer2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Information:");
        Terminal.WriteLine(" Made in Germany" +
                           "                    " +
                           "                     " +
                           " Last log : 18/09/1890" +
                           "                " +
                           "                       " +
                           " Specification:" +
                           "                     " +
                           "                     " +
                           " Illegal money transfer" +
                           "                 " +
                           " Access to the Deepweb" +
                           "                 " +
                           "                         " +
                           "Type 'continue' to go further");
        currentState = States.informatiecomputer2;
    }

    void Hacrequest1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("A mean while there comes suggestion   from computer and it says" +
                           "'Do you want to get rid of your work and live the rest of your life with pleasent?" +
                           "Then, we can hack somebody to gain money from him. But it's a risky process, there may be some people who can track us, like swat or fbi.." +
                           "Are you sure you want to do this ?'" +
                           "                                          ");
        Terminal.WriteLine("Type 'yes' to accept the suggestion or Type 'no' to reject the suggestion.");
        currentState = States.hackrequest1;
    }

    void Hacrequest2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("A mean while there comes suggestion   from computer and it says" +
                           "'Do you want to get rid of your work and live the rest of your life with pleasent?" +
                           "Then, we can hack somebody to gain money from him. But it's a risky process, there may be some people who can track us, like swat or fbi..." +
                           "Are you sure you want to do this ?'" +
                           "                                           ");
        Terminal.WriteLine("Type 'yes' to accept the suggestion or Type 'no' to reject the suggestion.");
        currentState = States.hackrequest2;
    }

    void Hackja1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Florean opens the software which it uses for hacking the people" +
                           "                ---------------Proccessing---------------" +
                           "-----------------Cracking---------------------" +
                           "------------------------------------------------" +
                           "Done." +
                           "-------------------" +
                           "                                        " +
                           "Type 'dascoin' to see how much you have got.");
        currentState = States.hackja1;
    }

    void Hackja2() //hier komt dascoin anders met swat sierenen
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Florean opens the software which it uses for hacking the people" +
                           "                ---------------Proccessing---------------" +
                           "-----------------Cracking---------------------" +
                           "------------------------------------------------" +
                           "Done." +
                           "-------------------" +
                           "                                        " +
                           "Type 'dascoin' to see how much you have got.");
        currentState = States.hackja2;
    }

    void Meldingbitcoin1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "you have seen you have got 60 bitcoin and that's mean that you have money to buy everything you want." +
            "The Computer wants your account so you can transfer the money to your second fake account which no one can track it." +
            "You gave your account and there comes an alert. It says '-NOTIFICATION- POLICE IS ON THE WAY -ALERT-'" +
            "'SUGGESTION = CHANGE YOUR WIFI!'" +
            "                                                     " +
            "You want to change your wifi or keep surfing on the computer?" +
            "Type 'yes' to change your wifi or Type 'no' to keep surfing in the computer.");
        currentState = States.meldingbitcoin1;
    }

    void Wifichange()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("'You have changed your wifi, well done." +
                           "Now we can go further'" +
                           "Type 'request' to open the requests window.");
        currentState = States.wifija;
    }

    void Wifinochange()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "You haven't changed your wifi. Well, dont mind it. It does not matter according my calculation'" +
            "You gave your account and there comes a new request menu" +
            "To open the request window type 'request'.");
        currentState = States.wifinee;
    }

    void Meldingbitcoin2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "you have seen you have got 60 bitcoin and that's mean that you have money to buy everything you want." +
            "The Computer wants your account so you can transfer the money to your second fake account which no one can track it." +
            "You gave your account and there comes a new request menu" +
            "To open the request window type 'request'.");
        currentState = States.meldingbitcoin2;
    }


    void Requests1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("             Menu              " +
                           "        What do you want to do, sir?" +
                           "                                        " +
                           "-Hack" +
                           "                                    " +
                           "-Deepweb" +
                           "                                       " +
                           "-Quit");
        currentState = States.requests1;
    }

    void Swats()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "The requests window opened but there is something wrong, because you hear some voices from outside." +
            "                            " +
            "*Siren sound*" +
            "                            " +
            "But you didn't mind it and keep surfed.." +
            "                              " +
            "5 minutes later the fbi polices are forcing to open the doors of your apartment." +
            "You closed the computer and take a look. After 1 minute silence.." +
            "To continue type 'silence'..");
        currentState = States.swats;
    }

    void Swatsend()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("FBI OPEN UP!!" +
                           "--------------------------------" +
                           "---------------------------------" +
                           "They got you arrested, bad luck.." +
                           "------------------------------------------" +
                           "                             " +
                           "           END                         " +
                           "                                    " +
                           "To turn back to the begin type 'mainmenu'.");
        currentState = States.swatsend;
    }

    void Deepweb1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("1");
        currentState = States.deepweb1;
    }

    void Deepweb2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("2");
        currentState = States.deepweb2;
    }

    void Requests2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("             Menu              " +
                           "        What do you want to do, sir?" +
                           "                                        " +
                           "-Hack" +
                           "                                    " +
                           "-Deepweb" +
                           "                                       " +
                           "-Quit");
        currentState = States.requests2;
    }

    void Quit1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Are you sure you want to quit?");
        Terminal.WriteLine("YES?       NO?");
        currentState = States.quit1;
    }

    void Quit2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Are you sure you want to quit?");
        Terminal.WriteLine("YES?       NO?");
        currentState = States.quit2;
    }

    void Quitja1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Shut downed..                            " +
                           "--------------------------------------------" +
                           "You have shoutdowned the computer, went to your home and want to forget everything what happened today." +
                           "-------------------------------------------" +
                           "Well, nothing happened. If you found out this end, you may be not a excited player. You are not looking for new excitement things :) " +
                           "-------------------------------------" +
                           "END ------------------------------" +
                           "To turn to the Main menu type 'mainmenu'.");
        currentState = States.quitja1;
    }

    void Quitja2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Shut downed..                            " +
                           "--------------------------------------------" +
                           "You have shoutdowned the computer, went to your home and want to forget everything what happened today." +
                           "-------------------------------------------" +
                           "Well, nothing happened. If you found out this end, you may be not a excited player. You are not looking for new excitement things :) " +
                           "-------------------------------------" +
                           "END ------------------------------" +
                           "To turn to the Main menu type 'mainmenu'.");
        currentState = States.quitja2;
    }
}